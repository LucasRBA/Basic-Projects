import React from 'react'
import { NavbarContainer } from './styles';
import { Link } from 'react-router-dom';

var title;
var href;

var links=[{title, href}]; 

const Navbar = ({ links }) => {
  links=[{title:'Calculator',href:'/calculator' },{title:'Unit Converter', href:'/unitconverter'}]

  return (
    <>
  <header>
    <link rel="preconnect" href="https://fonts.googleapis.com"/>
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin/>
    <link href="https://fonts.googleapis.com/css2?family=Inconsolata:wdth,wght@112.5,440&display=swap" rel="stylesheet"/>
  </header>
    <NavbarContainer className="navbar">
        {links.map(link => (
            <Link to={link.href}>{link.title}</Link>
        ))}
    </NavbarContainer>
    </>
)}

export default Navbar;
