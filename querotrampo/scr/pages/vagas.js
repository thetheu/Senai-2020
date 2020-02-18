import React, { Component} from 'react';
import { AsyncStorage, Text, View, StyleSheet, styles, TextInput, TouchableOpacity} from 'react-native';


class Login extends Component {
    
    static navigationOptions = {
        header: null,
    }

    constructor(){
        super();
        this.state = {
            email: "",
            senha: "",
        };
    }


    _realizarLogin = async () => {
        await fetch('http://corujasdev-001-site1.etempurl.com', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                email: "eve.holt@reqres.in",
                senha: "cityslicka"
            }),
        })
        .then(resposta => resposta.json())
        .then(data => this._token(data.token))
        .catch(erro => console.warn("ta erradooooooo", erro))
    }

    _token = async (tokenRecebido) => {
        if (tokenRecebido != null) {
            try {
                await AsyncStorage.setItem('nomeDoToken:token', tokenRecebido);
                this.props.navigation.navigate('MainNavigation')
            } catch (error) {
                console.warn("ta erradoooooooooooo", error)
            }
        }
    }

    render() {
        return(
          <View>

          <View>
              <Text>Senai</Text>
              <TextInput
                  placeholderTextColor="gray"
                  placeholder="email"
                  onChangeText={email => this.setState({ email })}
                  value={this.state.email}
                  
              />
              <TextInput
                  placeholderTextColor="gray"
                  placeholder="senha"
                  onChangeText={senha => this.setState({ senha })}
                  value={this.state.senha}
                  
              />
              <TouchableOpacity onPress={this._realizarLogin}>
                  <Text >Logar</Text>
              </TouchableOpacity>
          </View>
      </View>
        )
    }
}


export default Login;