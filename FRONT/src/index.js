import React from 'react';
import ReactDOM from 'react-dom';
import { useState } from 'react';
import './index.css';
import { BrowserRouter, Routes, Route } from "react-router-dom";
import useLocalStorage from 'use-local-storage';
import MainPage from './pages/MainPage/MainPage';
import Profile from './pages/Profile/Profile';

export default function App() {

//const [themeChosen, setThemeChosen] = useState(1);
  const defaultDark = window.matchMedia('(prefers-color-scheme: dark)').matches;
  const [theme,setTheme] = useLocalStorage('theme', defaultDark ? 'dark' : 'light');

//   function switchTheme(){
//     let newTheme = '';
//     switch (themeChosen){
//       case 0: 
//         newTheme = defaultDark? 'dark':'light'
//         break;
//       case 1: 
//         newTheme = defaultDark? 'light':'dark';
//         break;
//       case 2: 
//         newTheme = 'bubblegum_light'
//         break;
//       case 3: 
//         newTheme = 'bubblegum_dark'
//         break;
//       case 4: 
//         newTheme = 'nature'
//         break;
//       case 5: 
//         newTheme = 'gray'
//         break;
//       case 6: 
//         newTheme = 'halloween'
//         break;
//     }
//     setThemeChosen(themeChosen == 6? 0 : themeChosen + 1)
//     setTheme(newTheme);
//   }

  return (
    <div data-theme={"bubblegum_dark"}>
        

        <BrowserRouter>
        <Routes>
        

            <Route path="/" element={<MainPage />} />
            <Route path="/profile" element={<Profile />} />

        </Routes>
        </BrowserRouter>
    </div>
  );
}

ReactDOM.render(<App />, document.getElementById('root'));