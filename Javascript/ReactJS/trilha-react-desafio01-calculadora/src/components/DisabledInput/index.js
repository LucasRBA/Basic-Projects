import { InputContainer } from './styles';


const DisabledInput = ({value, operation}) => { 
    return (
      <InputContainer>
       <><input disabled value={value}/ >{(operation === '' || operation === null )? '' : <span >{operation}</span> }</> 
      </InputContainer>
    );
  }
  
  export default DisabledInput;