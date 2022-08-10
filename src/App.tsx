import React from 'react';
import Square from './components/square/Square';
import NavBar from './components/NavBar/NavBar';
import NavBarMobile from './components/NavBarMobile/NavBarMobile';
import Following from './components/Following/Following';
import useLocalStorage from 'use-local-storage';
import './App.scoped.css';

import { useMediaQuery } from "react-responsive";

let themeChosen = 0;

function App() {


  const isDesktop = useMediaQuery({

    query: "(min-width: 1224px)"

  });

  const isMobile = useMediaQuery({

    query: "(max-width: 786px)"

  });




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

      

      {isDesktop? <NavBar/> : <NavBarMobile/>}

      <button onClick={switchTheme}>
        Switch Theme
      </button>

      
      <Following />
      <Following />
      <Following />
      <Following />
    </div>
  );
}

export default App;
