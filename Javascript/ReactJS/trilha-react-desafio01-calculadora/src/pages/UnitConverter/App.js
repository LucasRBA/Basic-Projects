import React from 'react';

import convert from 'convert-units';

import Container from '@material-ui/core/Container';
import Grid from '@material-ui/core/Grid';

import Selector from '../../components/Selector/Selector'; 
import Input from '../../components/Input/Input';

import {ContainerStyle} from './styles'

class UnitConverterApp extends React.Component {
    constructor() {
        super();
        this.state = {
            mainSelector: '',
            firstUnit: '',
            secondUnit: '',
            firstInput: 0,
            secondInput: 0,
            flow: ''
        }
    }

    generateMainSelector = () => {
        return (
            convert().measures()
                .map(ele => ele[0].toUpperCase() + ele.slice(1))
        )
    }

    handleMainSelector = event => {
        event.preventDefault();
        this.setState({
            mainSelector: event.target.value,
            firstUnit: '',
            secondUnit: '',
            firstInput: 0,
            secondInput: 0
        })
    }

    handleSelector = event => {
        this.setState({[event.target.name]: event.target.value, firstInput: 0, secondInput: 0})
    }

    handleInputFields = event => {
        event.preventDefault();
        if(event.target.name === 'firstInput') {
            this.setState({
                firstInput: event.target.value,
                flow: 'L2R'
            },
            () => this.handleConversion())
        }
        else if(event.target.name === 'secondInput') {
            this.setState({
                secondInput: event.target.value,
                flow: 'R2L'
            },
            () => this.handleConversion())
        }
    }

    handleConversion = () => {
        if(this.state.flow === 'L2R') {
            this.setState({
                secondInput: convert(this.state.firstInput).from(this.state.firstUnit).to(this.state.secondUnit)
            })
        }
        else if(this.state.flow === 'R2L') {
            this.setState({
                firstInput: convert(this.state.secondInput).from(this.state.secondUnit).to(this.state.firstUnit)
            })
        }
    }

    render() {
        console.log(convert().possibilities())
        return (
            <ContainerStyle>
            <Container>
                <Grid container justify='center' align='center' spacing={3}>
                    <Selector data={{ size: 12, label: 'Measurement', measurements: convert().measures(), populateType: 'mainSelector', populateWith: this.generateMainSelector(), selectedValue: this.state.mainSelector }} handleSelector={this.handleMainSelector} />
                    {
                        this.state.mainSelector ? (
                            <>
                                <Selector data={{ size: 6, label: 'Unit', populateType: 'firstUnit', populateWith: convert().list(this.state.mainSelector), selectedValue: this.state.firstUnit }} handleSelector={this.handleSelector} />
                                <Selector data={{ size: 6, label: 'Unit', populateType: 'secondUnit', populateWith: convert().list(this.state.mainSelector), selectedValue: this.state.secondUnit }} handleSelector={this.handleSelector} />
                            </>
                        ) :(<></>)
                    }
                    {
                        this.state.firstUnit && this.state.secondUnit ? (
                            <>
                                <Input data={{ currentValue: this.state.firstInput, input: this.state.firstUnit, label: this.state.firstLabel, name: 'firstInput' }} handleInput={this.handleInputFields} />
                                <Input data={{ currentValue: this.state.secondInput, input: this.state.secondUnit, label: this.state.secondLabel, name: 'secondInput' }} handleInput={this.handleInputFields} />
                            </>
                        ) : (<></>)
                    }
                </Grid>
            </Container>
            </ContainerStyle>
        )
    }
}

export default UnitConverterApp;
