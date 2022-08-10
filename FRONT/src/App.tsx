import React from 'react';
import Square from './components/square/Square';
import NavBar from './components/NavBar/NavBar';
import useLocalStorage from 'use-local-storage';
import './App.scoped.css';

let themeChosen = 0;

function App() {
  const defaultDark = window.matchMedia('(prefers-color-scheme: dark)').matches;
  const [theme, setTheme] = useLocalStorage('theme', defaultDark ? 'dark' : 'light');

  const switchTheme = () => {

    let newTheme = '';

    switch (themeChosen){
      case 0: 
        if(defaultDark){
          newTheme = 'light'
        }else{
          newTheme = 'dark'
        }
        break;
      case 1: 
        if(defaultDark){
          newTheme = 'dark'
        }else{
          newTheme = 'light'
        }
        break;
      case 2: 
        newTheme = 'bubblegum_light'
        break;
      case 3: 
        newTheme = 'bubblegum_dark'
        break;
      case 4: 
        newTheme = 'nature'
        break;
      case 5: 
        newTheme = 'gray'
        break;
      case 6: 
        newTheme = 'halloween'
        themeChosen = 0;
        break;
    }
    console.log("theme: ", newTheme, "themeChosen: ", themeChosen);
    

    themeChosen++;
    setTheme(newTheme);
  }

  return (
    <div className="app" data-theme={theme}>

      <NavBar />

      <span>Easy Darkmode and Themes in React</span>

      <button onClick={switchTheme}>
        Switch Theme
      </button>

      
      <Square />
    </div>
  );
}

export default App;
