import React, { FC } from 'react';
import styles from './Following.module.css';
import ProfilePic from '../../assets/pics/pic_4.jpg';
import PostPic from '../../assets/pics/pic_5.jpg';

interface FollowingProps {}

const Following: FC<FollowingProps> = () => (
  <div className={styles.Following}>

    <div className={styles.profile_container}>
      <img className={styles.profile} src={ProfilePic} alt="" />
    </div>

    <div className={styles.content}>

      <div className={styles.Username}>
        <h1>Username</h1>
      </div>

      <span className={styles.description}>
        <h2>Lorem ipsum dolor sit amet</h2>
        <h2>5h</h2>
      </span>

      
      <div className={styles.picture_container}>
        <img className={styles.picture} src={PostPic} alt="" />
      </div>
    </div>

  </div>
);

export default Following;
