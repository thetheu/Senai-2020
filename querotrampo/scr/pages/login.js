import React, { Component} from 'react';
import { AsyncStorage, Text, View, StyleSheet, TextInput, TouchableOpacity} from 'react-native';


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
        await fetch('http://5e4eea5b6272aa0014231131.mockapi.io/LoginTeste', {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
        },
            body: JSON.stringify({
                email: this.state.email,
                senha: this.state.senha
            }),
        })
        .then(resposta => resposta.json())
        .then(data => this._token(data.token))
        .catch(erro => console.warn('errrraddooooo', erro))
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
              <View style={styles.logo}>
                <Text style={styles.f1}>SENAI</Text>
                <Text style={styles.f2}>INFORMATICA</Text>
              </View>
                <Text style={styles.f3}>QueroTrampar</Text>

          <View>
              <TextInput
                  placeholderTextColor="gray"
                  placeholder="email"
                  onChangeText={email => this.setState({ email })}
                  value={this.state.email}
                  style={styles.email}
              />
              <TextInput
                  placeholderTextColor="gray"
                  placeholder="senha"
                  onChangeText={senha => this.setState({ senha })}
                  value={this.state.senha}
                  style={styles.senha} 
                  secureTextEntry={true}
              />
              <TouchableOpacity onPress={this._realizarLogin}>
                  <Text style={styles.botao}>Logar</Text>
              </TouchableOpacity>
          </View>
      </View>
        )
    }
}

const styles = StyleSheet.create({
    logo:{
        flexDirection: 'row',
        borderWidth: 1.5,
        borderRadius: 2,
        borderColor: '#ddd',
        borderBottomWidth: 0,
        shadowColor: '#ddd',
        shadowOffset: { width: 1, height: 1 },
        shadowOpacity: 1,
        shadowRadius: 2,
        elevation: 9,
        marginLeft: 49,
        marginRight: 47,
        marginTop: 130,
        backgroundColor: "#f23838",
        borderRadius: 5,
    },
    f1: {
        fontSize: 25,
        fontFamily: "Segoe UI",
        marginLeft: 10,
        marginRight: 0,
        marginBottom: 3,
        marginTop: 3,
        color: 'white'
    },
    f2: {
        fontSize: 25,
        marginLeft: 7,
        marginTop: 3,
        color: 'white'
    },
    f3: { 
        fontSize: 17,
        fontFamily: "monospace",
        marginLeft: 170,
    },


    email: {
        fontSize: 15,
        backgroundColor: '#d9d9d9',
        marginTop: 110,
        marginLeft: 70,
        marginRight: 70,
        borderRadius: 5,
        height: 40,
    },
    senha: {
        fontSize: 15,
        backgroundColor: '#d9d9d9',
        marginTop: 30,
        marginLeft: 70,
        marginRight: 70,
        borderRadius: 5,
        height: 40,
    },
    botao: {
        backgroundColor: '#d9d9d9',
        marginLeft: 80,
        marginRight: 50,
        marginTop: 30,
        textAlign: 'center',
        borderRadius: 100,
        color: 'black',
        width: 200,
        height: 25,
        textAlignVertical: 'center'
    },
})

export default Login;