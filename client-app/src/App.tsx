import { useState, useEffect } from "react";
import {Member} from '../domain/Memeber'

import axios from "axios";
import { List, Header } from "semantic-ui-react";

function App() {

const [memebers, setMemebers] = useState([])

useEffect( () => {
   axios.get("http://localhost:5000/api/Members").then( response => {
    setMemebers(response.data)
   })
}, []);

  return (
     <>
   
   <Header as='h2' icon="users" content="Welcome to ECN " />
     {

      memebers.map( (memeber: Member)  => 
      <List key={memeber.id} >
      <List.Item >{memeber.firstName}</List.Item>  
      </List>  )
     }
     </>
  )
}

export default App
