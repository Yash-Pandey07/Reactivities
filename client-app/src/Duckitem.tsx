import { Duck } from "./demo"

interface Props{
    duck: Duck
}

export default function Duckitems({duck}: Props){     //Either replace each duck with props.duck.property 
    return(                                          //But we can directly pass the property we want to change
        <div key={duck.name}>
            <span>{duck.name}</span>
            <button onClick={() => duck.makeSound(duck.name + ' quack')}>Make Sound</button>
        </div>
    )
}