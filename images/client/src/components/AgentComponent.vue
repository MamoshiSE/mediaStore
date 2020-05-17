<template>
  <section class="blog-section spad">
        <div class="container">
           
                    <div class="section-title text-white">
                        <h2 class="text-center">Valorant Agents</h2>
                    </div>



        
    
    <p class="error" v-if="error">{{ error }}</p>
      <div v-for="agents in groupedAgents" v-bind:key="agents" class="row top-buffer">
    <div class= "col-lg-3 col-md-3 col-sd-12 col-xs-12 thumb"
    v-for="(agent, index) in agents" 
        v-bind:item="agent"
        v-bind:index="index"
        v-bind:key="agent._id"
         >

               
                    <a v-bind:href="'agents/'+ agent.name" >
                        <img :src="agent.img" class="zoom img-fluid " alt="">
                   
                     <h3 class="agent-name text-center" >{{agent.name}}</h3>
 </a>

        </div>
    </div>
    </div>
    </section>

   
</template>
<style>
   h3.agent-name:hover {
       color: #b01ba5;
    }
    
  

</style>
<script>
    import AgentService from '../AgentService';
    import _ from 'lodash'
export default {
  name: 'AgentComponent',
  data() {
      return {
          agents: [],
         
      }
  },
    
    computed: {
      groupedAgents(){
          return _.chunk(this.agents, 4);
      }
    },
    async created() {
        try {
            this.agents = await AgentService.getAgents();
        } catch(err) {
            this.error = err.message;
        }
    }
}
</script>

