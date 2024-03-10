import styled from 'styled-components';

export const InputContainer = styled.div`
    width: 100%; 
    height: 5rem;
    background-color: turquoise;

    display: flex;
    align-items: center;
    justify-content: flex-end;

    font-size: 1.5rem;
    font-family: 'Inconsolata', sans-serif;
    box-sizing: border-box; 
    border-top-right-radius: 1.6rem;
    border-top-left-radius: 1.6rem; 
    overflow: hidden; 
    

    input {
        width: 100%;
        height: 5rem;
        background-color: turquoise;
        border: 0;
        display: flex;
        direction: rtl!important;
        text-align: right; 
        padding: 0 0.8rem;
        font-size: 1.8rem;
        font-family: 'Inconsolata', sans-serif; 
        color: #FFFFFF;
        padding-right: 4rem;
        unicode-bidi: plaintext; 

    }

    span{
        width:3rem;
        height:3rem;
        background-color: #879492f7;
        border-radius: 35%;
        display: flex;
        align-items: center; 
        justify-content: center;
        margin-right: 1rem; 
        color:white;
    }
`