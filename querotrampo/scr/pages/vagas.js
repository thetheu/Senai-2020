import React, { Component } from 'react';
import { Text, View, AsyncStorage, StyleSheet, Image } from 'react-native';
// import { FlatList } from 'react-native-gesture-handler';

class Vagas extends Component {

    static navigationOptions = {
        header: null,
    }

    constructor() {
        super();
        this.state = {
            vagas: [],

        } 
    }

    componentDidMount() {
        this._listarVagas();
    }

    _listarVagas = async () => {
        await fetch('http://corujasdev-001-site1.etempurl.com',{
            headers: {
                'Authorization': 'Bearer ' + await AsyncStorage.getItem('@nomeDoToken:token')
            }
        })
        .then(response => response.json())
        .then(data => this.setState({ vagas: data}))
        .catch(error => console.warn("ta eraadooooooo" + error))
    }

    render() {
        return ( 
            <View>
                <Text>asdwasd</Text>
                
                {/* <FlatList
                data={this.state.vagas}
                keyExtractor={item => item.IdVagas}
                renderItem={({ item }) => (
                    <Text>{item.titulo}</Text>
                )}
                /> */}
            </View>
        )
    }
}

export default Vagas;