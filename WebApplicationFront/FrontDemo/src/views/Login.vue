<template> 
    <fieldset>
        <legend>Login</legend><label for="userName">用户名:</label>
        <input type="text" v-model="state.loginData.userName" id="userName" />
        <label for="password">密码:</label>
        <input type="password" v-model="state.loginData.password" id="password" />
        <input type="submit" value="登录" @click="loginSubmit"/>    
      </fieldset>
      <table v-if="state.processInfos.length>0">
          <thead>
              <tr><th style="width:50px;">进程Id</th><th style="width:20px;">进程名</th><th style="width:20px;">内存占用</th></tr>
          </thead>
          <tbody>
            <tr v-for="p in state.processInfos" :key="p.id">
                <td>{{p.id}}</td><td>{{p.name}}</td>
                <td>{{(p.workingSet/1024)}}KB</td>
            </tr>
          </tbody>
      </table>
</template>


<script>
    //javascript代码
    import axios from 'axios';//引入axios包
    import {reactive,onMounted} from 'vue'

    export default{ name:'Login',
        setup(){
            const state=reactive({loginData:{},processInfos:[]});//初始模型，字典
            //点击按钮调用的函数
            const loginSubmit=async()=>{
                const payload=state.loginData;//loginData作为报文体发送给服务器                
                //发送ajax请求，传递请求地址和请求体
                const resp=await axios.post('https://localhost:7160/api/Login/Login',payload);                
                const data=resp.data;//响应内容
                if(!data.ok)
                {
                    alert("登录失败");
                    return;
                }
                state.processInfos=data.processInfos;//进程详细信息赋值给模型
            }
            return {state,loginSubmit};
        },    
    }
</script>