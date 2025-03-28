import { useEffect, useState } from 'react'
import './App.css'
import axios from 'axios'
import { Header, List, ListItem } from 'semantic-ui-react';

function App() {
  const [activities, setActivities] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/activities')
      .then(response => {
        setActivities(response.data)
      })
  }, [])
  
  return (
    
    <div>
      <Header icon={"users"} content={"Reactivities"} as={"h2"} />
      <List>
        {activities.map((activity: any) => (
          <List.Item key={activity.id}>
            { activity.title }
          </List.Item>
        ))}
      </List>
    </div>
  )
}

export default App
