import './App.css';
import React, { useState, useEffect } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import axios from 'axios';
import logo from './assests/logoClassificados.png';
import { format } from 'date-fns';
import { Modal, ModalBody, ModalFooter, ModalHeader, Button } from 'reactstrap';

function App() {

  const baseUrl = `https://localhost:44330/api/classificados`;
  const getUrl = `https://localhost:44330/api/classificados/ordenadopordata`;
  const [data, setData] = useState([]);
  const [modalIncluir, setModalIncluir] = useState(false);

  const [classificadoSelecionado, setClassificadoSelecionado] = useState({
    id: '',
    titulo: '',
    descricao: '',
    dataCadastro: ''
  })

  const abrirFecharModalIncluir = ()=>{
    setModalIncluir(!modalIncluir)
  }

  const handleChange = e=>{
    const {name, value} = e.target;
    setClassificadoSelecionado({
      ...classificadoSelecionado, [name]:value
    })
  }
  
  const pedidoGet = async()=> {
    await axios.get(getUrl)
    .then(response => {
      setData(response.data);
    }).catch(error => {
      console.log(error);
    })
  }

  const pedidoPost = async()=> {
    delete classificadoSelecionado.id;
    delete classificadoSelecionado.dataCadastro;
    await axios.post(baseUrl, classificadoSelecionado)
    .then(response => {
      setData(data.concat(response.data));
      abrirFecharModalIncluir();
    }).catch(error => {
      console.log(error);
    })
  }

  useEffect(()=>{
    pedidoGet();
  }, [data])

  return (
    <div className="App"> 
      <br/>
      <h3>Classificados</h3>
      <header>
      <img src={logo} alt='Classificados' className='imagem'/>
        <Button className="btn btn-success" onClick={()=>abrirFecharModalIncluir()}>+ Novo Classificado</Button>
      </header>
      <table className='table table-bordered'>
        <thead>
          <tr>
            <th>Título</th>
            <th>Data de Publicação</th>
            <th>Descrição</th>
          </tr>
        </thead>
        <tbody>
            {data.map(classificado=>(
              <tr key={classificado.id}>
                <td>{classificado.titulo}</td>
                <td>{new Date(classificado.dataCadastro).toLocaleString(
                  'pt-BR', { day: '2-digit', month: 'long', year: 'numeric', hour: '2-digit', minute: '2-digit' })}</td>
                <td>{classificado.descricao}</td>
              </tr>
            ))}
        </tbody>
      </table>
      <Modal isOpen={modalIncluir}>
        <ModalHeader>Publicar Classificado</ModalHeader>
        <ModalBody>
          <div className='form-group'>
          <label>Título</label>
          <br/>
          <input type='text' className='form-control' name='titulo' onChange={handleChange}/>
          <br/>
          <label>Descrição</label>
          <br/>
          <input type='text' className='form-control' name='descricao' onChange={handleChange}/>
          <br/>
          </div>
        </ModalBody>
        <ModalFooter>
          <button className='btn btn-primary' onClick={()=>pedidoPost()}>Confirmar</button>{''}
          <button className='btn btn-danger' onClick={()=>abrirFecharModalIncluir()}>Cancelar</button>
        </ModalFooter>
      </Modal>
    </div>
  );
}

export default App;
