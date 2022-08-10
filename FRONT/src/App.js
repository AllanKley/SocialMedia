import React from 'react';
import NavBar from './components/NavBar/NavBar';
import NavBarMobile from './components/NavBarMobile/NavBarMobile';
import FooterMobile from './components/FooterMobile/FooterMobile';
import Following from './components/Following/Following';
import useLocalStorage from 'use-local-storage';
import './App.css';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';

import { useMediaQuery } from "react-responsive";

let themeChosen = 0;

function App() {

  const isDesktop = useMediaQuery({query: "(min-width: 1100px)"});

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
    <>
       
      <div className="app" data-theme={theme}>

        {isDesktop? <NavBar/> : <NavBarMobile/>}

        <Router> 
          <button onClick={switchTheme}>
            Switch Theme
          </button>

          <Routes>
            <Route path='/' element={<Following />}/>
          </Routes>

        </Router>


        {!isDesktop? <FooterMobile/> : null}

      </div>
    </>
  );
}

export default App;
