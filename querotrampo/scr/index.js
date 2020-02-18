import Login from './pages/login';
import Vagas from './pages/vagas';
import { createBottomTabNavigator } from 'react-navigation-tabs';
import { createAppContainer, createSwitchNavigator } from 'react-navigation';
import { createStackNavigator } from '@react-native-community/masked-view'

const AuthStack = createStackNavigator({
  Sign: { screen: Login },
})

const MainNavigator = createBottomTabNavigator({

  VagasScreen: {
      screen: Vagas
  }
});

export default createAppContainer(
  createSwitchNavigator(
      {
          MainNavigator,
          AuthStack,
      },
      {
          initialRouteName: 'AuthStack'
      },
  ),
)
