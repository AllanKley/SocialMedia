import React, { FC } from 'react';
import styles from './FooterMobile.module.css';
import { ReactComponent as Search } from '../../assets/icons/Search.svg'
import { ReactComponent as Messages } from '../../assets/icons/Messages.svg'
import { ReactComponent as Create } from '../../assets/icons/Plus.svg'
import { ReactComponent as Home } from '../../assets/icons/Home.svg'
import ProfilePic from '../../assets/pics/pic_1.jpg'




const FooterMobile = () => (
  <div className={styles.FooterMobile}>
    <header className={styles.NavBar}>

    <div className={styles.iconContainer}>
      <Home className={styles.icon}/>
    </div>

    <div className={styles.iconContainer}>
      <Search className={styles.icon}/>
    </div>

    <div className={styles.iconContainer}>
      <Create className={styles.icon}/>
    </div>

    <div className={styles.iconContainer}>
      <Messages className={styles.icon}/>
    </div>

    <img src={ProfilePic} alt="" className={styles.profilePic} />

    </header>
  </div>
);

export default FooterMobile;
