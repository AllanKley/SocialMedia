import React, { FC } from 'react';
import styles from './NavBarMobile.module.css';
import { ReactComponent as Logo } from '../../assets/icons/BrandLogo.svg'
import { ReactComponent as Search } from '../../assets/icons/Search.svg'
import { ReactComponent as Messages } from '../../assets/icons/Messages.svg'
import { ReactComponent as Alert } from '../../assets/icons/Alert.svg'
import ProfilePic from '../../assets/pics/pic_1.jpg'

interface NavBarMobileProps {}

let navItem = 0
let notification = false
let messages = true

const NavBarMobile: FC<NavBarMobileProps> = () => (
  <div>
    <header className={styles.NavBar}>

        <a className={styles.navLink}>Explore</a>
        <a className={styles.navLink}>Following</a>

    </header>
  </div>
);

export default NavBarMobile;
