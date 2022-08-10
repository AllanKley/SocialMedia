import React, { FC } from 'react';
import styles from './NavBar.module.css';
import { ReactComponent as Logo } from '../../assets/icons/BrandLogo.svg'
import { ReactComponent as Search } from '../../assets/icons/Search.svg'
import { ReactComponent as Messages } from '../../assets/icons/Messages.svg'
import { ReactComponent as Alert } from '../../assets/icons/Alert.svg'
import ProfilePic from '../../assets/pics/pic_1.jpg'

interface NavBarProps {}

let navItem = 0
let notification = false
let messages = true

const NavBar: FC<NavBarProps> = () => (
  <div>
    <div className={styles.space}></div>
    
    <header className={styles.NavBar}>
      
      <div className={styles.left}>
        <Logo className={styles.logo}/>
        <div className={styles.search}>
          <Search className={styles.searchIcon}/>
          <input type="text" placeholder='Search' className={styles.searchInput}/>
        </div>
      </div>

      <div className={styles.center}>
        <a className={styles.navLink}>Explore</a>
        <a className={styles.navLink}>Following</a>
      </div>

      <div className={styles.right}>
        
        <div className={styles.icons}>
          <div className={styles.iconBox}>
            {notification? <div className={styles.notification}></div>: null }
            <Messages className={styles.messagesIcon}/>
          </div>

          <div className={styles.iconBox}>
            {messages? <div className={styles.notification}></div>: null }
            <Alert className={styles.alertIcon}/>
          </div>
        </div>

        <img src={ProfilePic} alt="" className={styles.profilePic} />

      </div>

    </header>
  </div>
);

export default NavBar;