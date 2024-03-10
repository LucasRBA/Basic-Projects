
import DisabledInput from '../../components/DisabledInput';
import Button from '../../components/Button';

import { Container, Content, Row } from './styles';
import { useState } from 'react';


const CalculatorApp = () => {
  const [currentNumber, setCurrentNumber] = useState('0');
  const [firstNumber, setFirstNumber] = useState('0');
  const [operation, setOperation] = useState('');

  const handleOnClear = () => {
    setCurrentNumber('0')
    setFirstNumber('0')
    setOperation('')
  };

  const handleAddNumber = (num) => {
    setCurrentNumber(prev => `${prev === '0' ? '' : prev}${num}`)
  }

  const handleSumNumbers = () => {

    if(firstNumber === '0'){
        setFirstNumber(String(currentNumber));
        setCurrentNumber('')
        setOperation('+')
    }else {
      const sum = Number(firstNumber) + Number(currentNumber);
      setCurrentNumber(String(sum))
      setOperation('')
    }

    //TODO CREATE PAGE FOR UNITS CONVERSION
  }

  const handleMinusNumbers = () => {

    if(firstNumber === '0'){
        setFirstNumber(String(currentNumber));
        setCurrentNumber('')
        setOperation('-')
    }else {
      setCurrentNumber(String(firstNumber))
      const sum = Number(firstNumber) - Number(currentNumber);
      setCurrentNumber(String(sum))
      setOperation('')
    }

  }

  const handleMultiplyNumbers = () => {

    if(firstNumber === '0'){
        setFirstNumber(String(currentNumber));
        setCurrentNumber('')
        setOperation('*')
    }else{
      const multiplication = Number(firstNumber) * Number(currentNumber);
      setCurrentNumber(String(multiplication))
      setOperation('')
    }
  }

  const handleDivideNumbers = () => {
    if(firstNumber === '0'){
      setFirstNumber(String(currentNumber));
      setCurrentNumber('')
      setOperation('/')
    }else{
      const division = Number(firstNumber) / Number(currentNumber);
      setCurrentNumber((currentNumber === "0" ? 'ERROR:NaN' : String(division)));
      (String(division) === 'Infinity' || String(division) === '-Infinity') ? alert("ERROR:Division by zero") : console.log(division);
      setOperation('')
    }  
 }

  const handleFloatNumbers = () => {
    if(!currentNumber.includes('.')){
      setCurrentNumber(`${currentNumber}.`)
    }else{
      return;
    }
  }

  const handleSquareRoot = () => {
    if(firstNumber === '0'){
        setFirstNumber(String(currentNumber));
        setOperation('√')
    }else{
      const squareRoot = Math.sqrt(Number(currentNumber))
      setCurrentNumber(String(squareRoot))
    }
  }

  const handleSquare = () =>{
    if(firstNumber === '0'){
        setFirstNumber(String(currentNumber));
        setOperation('x²')
    }else{
      const square = Number(currentNumber) * Number(currentNumber);
      setCurrentNumber(String(square))
    }
  }

const handlePercentage = () => {
  if(firstNumber === '0'){
      setFirstNumber(String(currentNumber));
      setOperation('%')
  }else{
    const percentage = Number(currentNumber) / 100;
    setCurrentNumber(String(percentage))
  }
}

  const handleEquals = () => {
  try{
    if(firstNumber !== '0' && operation !== '' ){
        switch(operation){
          case '+':
            handleSumNumbers();
            break;
          case '-':
            handleMinusNumbers();
            break;
          case '*':
            handleMultiplyNumbers();
            break;
          case '/':
            handleDivideNumbers();
            break;
          case '√':
            handleSquareRoot();
            break;
          case 'x²':
            handleSquare();
            break;
          case '%':
            handlePercentage();
            break;
          default: 
            break;
        }
    }
  }catch(error ) {
    console.log('Error: ', error);
  }finally{
    setOperation('');
  }

  }

  return (<>
    <Container>
      <Content>
        <DisabledInput value={currentNumber} operation={operation}/>
        <Row>
          <Button label="x" onClick={() => handleMultiplyNumbers()} />
          <Button label="√" onClick={handleSquareRoot} />
          <Button label="C" onClick={handleOnClear}/>
          <Button label="x²" onClick={handleSquare} />
        </Row>
        <Row>
          <Button label="7" onClick={() => handleAddNumber('7')}/>
          <Button label="8" onClick={() => handleAddNumber('8')}/>
          <Button label="9" onClick={() => handleAddNumber('9')}/>
          <Button label="÷" onClick={handleDivideNumbers}/>
        </Row>
        <Row>
          <Button label="4" onClick={() => handleAddNumber('4')}/>
          <Button label="5" onClick={() => handleAddNumber('5')}/>
          <Button label="6" onClick={() => handleAddNumber('6')}/>
          <Button label="-" onClick={handleMinusNumbers}/>
        </Row>
        <Row>
          <Button label="1" onClick={() => handleAddNumber('1')}/>
          <Button label="2" onClick={() => handleAddNumber('2')}/>
          <Button label="3" onClick={() => handleAddNumber('3')}/>
          <Button label="+" onClick={handleSumNumbers}/>
        </Row>
        <Row>
          <Button label="0" onClick={() => handleAddNumber('0')}/>
          <Button label="." onClick={() => handleFloatNumbers()} />
          <Button label="%" onClick={handlePercentage} /> 
          <Button label="=" onClick={handleEquals} />      
        </Row>
      </Content>
    </Container>
    </>
  );
}

export default CalculatorApp;
