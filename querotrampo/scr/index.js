
import { createAppContainer, createSwitchNavigator } from 'react-navigation';
import { createStackNavigator } from '../node_modules/react-navigation-stack';
import { createBottomTabNavigator } from 'react-navigation-tabs';

import LoginScreen from './pages/login';
import VagasScreen from './pages/vagas';
import Login from './pages/login';

const AuthStack = createStackNavigator({
    Login: { screen: LoginScreen}
})

const MainNavigator = createBottomTabNavigator(
    {
        Vagas: {
            screen: VagasScreen
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