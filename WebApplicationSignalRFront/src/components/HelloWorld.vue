<script>
import { reactive, onMounted } from 'vue';
import * as signalR from '@microsoft/signalr';

let connection;
export default{name:'Login', setup(){
  const state = reactive({ userMessage: "", messages: [] });
  const txtMsgOnkeypress = async function (e) {  
    if(e.keyCode != 13) return;
    //服务器端的方法名字SendPublicMessage
    await connection.invoke("SendPublicMessage",state.userMessage);
    state.userMessage = "";
  };
    //初始化
    onMounted(async function(){
      connection=new signalR.HubConnectionBuilder()
          .withUrl('https://localhost:7244/MyHub')
          .withAutomaticReconnect().build();
      //启动
      await connection.start();
      //监听
      connection.on('PublicMessageReceived',msg=>{
        state.messages.push(msg);
      });
    });
    return {state,txtMsgOnkeypress};
  },
}
</script>

<template>
  <input type="text" v-model="state.userMessage" v-on:keypress="txtMsgOnkeypress"/>
  <div>
    <ul>
      <li v-for="(msg,index) in state.messages" :key="index">{{msg}}</li>
    </ul>
  </div>
</template>

