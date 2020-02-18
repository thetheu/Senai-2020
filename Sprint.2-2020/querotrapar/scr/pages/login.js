import React, { Component} from 'react';
import { AsyncStorage, Text, View, StyleSheet} from 'react-native';


class Login extends Component {
    
    // static navigationOptions = {
    //     header: null,
    // }

    // constructor(){
    //     super();
    //     this.state = {
    //         email: "",
    //         senha: "",
    //     };
    // }


    // _realizarLogin = async () => {
    //     await fetch('http://corujasdev-001-site1.etempurl.com', {
    //         method: 'POST',
    //         headers: {
    //             'Accept': 'application/json',
    //             'Content-Type': 'application/json'
    //         },
    //         body: JSON.stringify({
    //             email: "eve.holt@reqres.in",
    //             senha: "cityslicka"
    //         }),
    //     })
    //     .then(resposta => resposta.json())
    //     .then(data => this._token(data.token))
    //     .catch(erro => console.warn("ta erradooooooo", erro))
    // }

    // _token = async (tokenRecebido) => {
    //     if (tokenRecebido != null) {
    //         try {
    //             await AsyncStorage.setItem('nomeDoToken:token', tokenRecebido);
    //             this.props.navigation.navigate('MainNavigation')
    //         } catch (error) {
    //             console.warn("ta erradoooooooooooo", error)
    //         }
    //     }
    // }

    render() {
        return(
            <View>
                <Text>Socorro, que tudo esteja certo</Text>
            </View>
        )
    }
}


export default Login;