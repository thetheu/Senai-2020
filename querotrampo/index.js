import {AppRegistry} from 'react-native';
import App from './App';
import Login from './scr/pages/login';
import {name as appName} from './app.json';
import Index from './scr/index';

AppRegistry.registerComponent(appName, () => Index);
