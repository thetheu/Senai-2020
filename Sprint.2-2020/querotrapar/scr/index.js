import { creatStackNavigator } from 'react-navigation-stack';

import LoginScreen from './pages/login';
import VagaScreen from './pages/vagas';

const AuthStack = creatStackNavigator({
    Sign: { screen: LoginScreen },
})

const MainNavigator = createBottomTabNavigator({

    VagasScreen: { 
        screen: VagaScreen
    }
})

export default createAppContainer(
    creatSwitchNavigator(
        {
            MainNavigator,
            AuthStack,       
        },
        {
            initialRouteName: 'AuthStack'
        }
    )
)
