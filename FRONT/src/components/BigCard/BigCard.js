import React from 'react';
import PropTypes from 'prop-types';
import styles from './BigCard.module.css';

import ProfilePic from '../../assets/pics/pic_4.jpg';
import ProfilePic2 from '../../assets/pics/pic_3.jpg'

import PostPic from '../../assets/pics/pic_5.jpg';

import { ReactComponent as Save } from '../../assets/icons/Save.svg'
import { ReactComponent as Share } from '../../assets/icons/Share.svg'
import { ReactComponent as Comment } from '../../assets/icons/Comment.svg'
import { ReactComponent as Like } from '../../assets/icons/Like.svg'

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
        {props.Post.PostPicRatio == 1? <img className={styles.picture_square} src={PostPic} alt="" /> : null}
        {props.Post.PostPicRatio == .5? <img className={styles.picture_wide} src={PostPic} alt="" /> : null}
        {props.Post.PostPicRatio == 2? <img className={styles.picture_tall} src={PostPic} alt="" /> : null}
      </div>

      <div className={styles.interactions}>

        <div className={styles.interaction}>
       
            <Like className={styles.icon}/>
            <h3>15</h3>
        </div>

        <div className={styles.interaction}>
            <Comment className={styles.icon}/>
            <h3>15</h3>
        </div>

        <div className={styles.interaction}>
            <Share className={styles.icon}/>     
        </div>

        <div className={styles.interaction}>
            <Save className={styles.icon} />
        </div>
      </div>

      <div className={styles.comments}>
        <div className={styles.comment}>
          <img src={ProfilePic2} alt="" className={styles.commentPic} />
          <h4>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quis ipsum non odio imperdiet fringilla et ac erat.</h4>
        </div>

        <div className={styles.comment}>
          <img src={ProfilePic2} alt="" className={styles.commentPic} />
          <h4>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quis ipsum non odio imperdiet fringilla et ac erat.</h4>
        </div>

        <div className={styles.showComments}>
          View all 8 comments
        </div>
      </div>
    </div>
  </div>
);

export default BigCard;
