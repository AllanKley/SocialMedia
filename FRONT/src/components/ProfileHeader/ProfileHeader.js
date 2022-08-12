import React from 'react';
import PropTypes from 'prop-types';
import styles from './ProfileHeader.module.css';
import CoverPic from '../../assets/pics/pic_6.jpg'
import ProfilePic from '../../assets/pics/pic_1.jpg'
import { ReactComponent as Return } from '../../assets/icons/Return.svg'
import { Outlet, Link } from "react-router-dom";

let User = {
  Name: "Allan Kley",
  Username: "@Allan_Kley",
  CreationDate: new Date(2000, 8, 11),
  ProfilePic: ProfilePic,
  CoverPic: CoverPic,
  Followers: 65,
  Following: 32
}

const ProfileHeader = () => (


  <div className={styles.ProfileHeader}>
    <div className={styles.Cover}>

      <Link to="/">
        <div className={styles.iconContainer}>
          <Return className={styles.icon}/>
        </div>
      </Link>
      <img src={User.CoverPic} className={styles.CoverImg}/>

    </div>
   
    
    <div className={styles.Info}>
      <div className={styles.Profile}><img src={User.ProfilePic} className={styles.ProfilePic}/></div>
      <div className={styles.ProfileInfo}>
        
        <h1>{User.Name}</h1>
        <span>
          <h4>{User.Username}</h4>
          <h4 className={styles.secondaryText}>Joined {User.CreationDate.toDateString()}</h4>
        </span>
        <span>
          <h3>{User.Followers} Followers</h3>
          <h3>{User.Following} Following</h3>
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
