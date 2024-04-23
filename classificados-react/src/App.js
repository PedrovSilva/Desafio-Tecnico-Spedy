import './App.css';
import React, { useState, useEffect } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import axios from 'axios';
import logo from './assests/logoClassificados.png';
import { format } from 'date-fns';

import { Modal, ModalBody, ModalFooter, ModalHeader, Button } from 'reactstrap';
function App() {

  const baseUrl = `https://localhost:44330/api/classificados/ordenadopordata`;
  
  const [data, setData] = useState([]);
  
  const pedidoGet = async()=> {
    await axios.get(baseUrl)
    .then(response => {
      setData(response.data);
    }).catch(error => {
      console.log(error);
    })
  }

  useEffect(()=>{
    pedidoGet();
  })

  return (
    <div className="App"> 
      <br/>
      <h3>Classificados</h3>
      <header>
        <img src={logo}/>
        <Button className="btn btn-success">+ Novo classificado</Button>
      </header>
      <table className='table table-bordered'>
        <thead>
          <tr>
            <th>Título</th>
            <th>Data de Cadastro</th>
            <th>Descrição</th>
          </tr>
        </thead>
        <tbody>
            {data.map(classificado=>(
              <tr key={classificado.id}>
                <td>{classificado.titulo}</td>
                <td>{format(new Date(classificado.dataCadastro), 'dd/MM/yyyy HH:mm')}</td>
                <td>{classificado.descricao}</td>
              </tr>
            ))}
        </tbody>
      </table>
    </div>
  );
}

export default App;
