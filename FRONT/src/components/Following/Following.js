import React, { FC } from 'react';
import styles from './Following.module.css';
import BigCard from '../BigCard/BigCard'

let Posts = []
for(let i = 0; i < 5; i++){
  Posts.push({
    Description: "Pau no seu cu",
    CreationDate: "3d",
    User: {
      Name: "Luis Hamilton"
    }
  })
}

const Following = (props) => (
  
    <div className={styles.Following}>

      {Posts.map((Post) => <BigCard Post = {Post}/>)}

    </div>
 
);

export default Following;
