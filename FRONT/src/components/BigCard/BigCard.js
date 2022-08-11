import React from 'react';
import PropTypes from 'prop-types';
import styles from './BigCard.module.css';

import ProfilePic from '../../assets/pics/pic_4.jpg';
import PostPic from '../../assets/pics/pic_5.jpg';

const BigCard = (props) => (
  <div className={styles.BigCard}>
     <div className={styles.profile_container}>
      <img className={styles.profile} src={ProfilePic} alt="" />
    </div>

    <div className={styles.content}>

      <div className={styles.UserName}>
        <h1>{props.Post.User.Name}</h1>
      </div>

      <span className={styles.description}>
        <h2>{props.Post.Description}</h2>
        <h2>{props.Post.CreationDate}</h2>
      </span>

      
      <div className={styles.picture_container}>
        <img className={styles.picture} src={PostPic} alt="" />
      </div>
    </div>
  </div>
);

export default BigCard;
