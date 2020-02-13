import React, { Component } from 'react';
import { StyleSheet, View, Text, AsyncStorage, FlatList } from 'react-native';


class App extends Component {

  constructor() {
    super();
    this.state = {
      pacotes: [],
      novaLista: [],
    }
  }

  componentDidMount() {
    this._listarPacotes();
  }

  _listarPacotes = async () => {
    await fetch('http://192.168.5.81:5000/api/pacote')
      .then(response => response.json())
      .then(data => this.setState({ pacotes:data}))
  }

  render() {
    return (
      <View>
        <View>
          <Text style={styles.la}>Pacotes</Text>
          <FlatList
            data={this.state.pacotes}
            keyExtractor={item => item.Id}
            ListEmptyComponent={<Text>Não há itens</Text>}
            renderItem={({ item }) => (
              <View>
                <Text style={styles.titulo}>{item.titulo}</Text>
                <Text style={styles.sinopse}>{item.descricao}</Text>
              </View>
            )}
          />

          {/* <FlatList
                        data={this.state.Pacotes}
                        keyExtractor={item => item.Pacotes.Id}
                        renderItem={({ item }) => (
                            <View>
                                <Text >{item.titulo}</Text>
                                <Text >{item.descricao}</Text>
                            </View>
                        )}
                    /> */}

        </View>
      </View>
    );
  }
}

const styles = StyleSheet.create({
  tabela: {
    paddingTop: 20,
    paddingLeft: 10,
    paddingRight: 10,
},
la: {
  padding: 5,
  textAlign: "center",
  fontSize: 21,
  color: 'black',
  backgroundColor: '#888888'
},
});

export default App;
