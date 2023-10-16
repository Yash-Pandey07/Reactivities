import Duckitems from "./Duckitem"
import { ducks } from "./demo"

function App_demo() {

  return (
    <div>
      <h1>Welcome to Reactivities</h1>
      {ducks.map(duck => (
        <Duckitems key={duck.name} duck={duck} />
      ))}
    </div>
   
  )
}

export default App_demo
