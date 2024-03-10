import React from 'react';
import ReactDOM from 'react-dom/client';
import CalculatorApp from '../src/pages/Calculator/App';
import Navbar from './components/Navbar/navbar';
import GlobalStyles from './global';
import { BrowserRouter as Router, Route, Routes} from 'react-router-dom'; 
import UnitConverterApp from '../src/pages/UnitConverter/App';



const root = ReactDOM.createRoot(document.getElementById('root'));

root.render(
  <React.StrictMode>
      <Router>
        <Navbar />
        <Routes> 
          <Route path="/calculator" element={<CalculatorApp />} /> 
          <Route path="/unitconverter" element={<UnitConverterApp />} />  
        </Routes> 
      </Router>
    <GlobalStyles />
  </React.StrictMode>
);