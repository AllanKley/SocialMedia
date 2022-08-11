import React from 'react';
import './MainPage.css';

import NavBar from '../../components/NavBar/NavBar';
import NavBarMobile from '../../components/NavBarMobile/NavBarMobile';
import FooterMobile from '../../components/FooterMobile/FooterMobile';
import Following from '../../components/Following/Following';

import { useMediaQuery } from "react-responsive";
import { useState } from 'react';

function App() {

  const isDesktop = useMediaQuery({query: "(min-width: 1100px)"});

  return (
    <>
       
      <div className="app">

        {isDesktop? <NavBar/> : <NavBarMobile/>}

        <Following/>
            
        {!isDesktop? <FooterMobile/> : null}

      </div>
    </>
  );
}

export default App;
