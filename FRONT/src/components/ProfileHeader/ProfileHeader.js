import React from 'react';
import PropTypes from 'prop-types';
import styles from './ProfileHeader.module.css';
import Cover from '../../assets/pics/pic_6.jpg'
import Profile from '../../assets/pics/pic_1.jpg'
import { ReactComponent as Return } from '../../assets/icons/Return.svg'
import { Outlet, Link } from "react-router-dom";

const ProfileHeader = () => (
  <div className={styles.ProfileHeader}>
    <div className={styles.Cover}>

      <Link to="/">
        <div className={styles.iconContainer}>
          <Return className={styles.icon}/>
        </div>
      </Link>
      <img src={Cover} className={styles.CoverImg}/>

    </div>
   
    
    <div className={styles.Info}>
      <div className={styles.Profile}><img src={Profile} className={styles.ProfilePic}/></div>
      <div className={styles.ProfileInfo}>
        
        <h1>Allan Kley</h1>
        <span>
          <h4>@Allan_Kley</h4>
          <h4 className={styles.secondaryText}>@Joined August 4, 2022</h4>
        </span>
        <span>
          <h3>67 Followers</h3>
          <h3>32 Following</h3>
        </span>
      </div>

      
      <div className={styles.EditProfile}>
        <a className={styles.EditBtn}>Editar Perfil</a>
      </div>
    </div>
    
  </div>
);

ProfileHeader.propTypes = {};

ProfileHeader.defaultProps = {};

export default ProfileHeader;
