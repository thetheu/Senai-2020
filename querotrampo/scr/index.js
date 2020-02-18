
import { createAppContainer } from 'react-navigation';

import { createBottomTabNavigator } from 'react-navigation-tabs';

import LoginScreen from './pages/login';
import VagasScreen from './pages/vagas';

const MainNavigator = createBottomTabNavigator(
    {
        Login: {
            screen: LoginScreen
        },
        Vagas: {
            screen: VagasScreen
        }
    });

    export default createAppContainer(MainNavigator)