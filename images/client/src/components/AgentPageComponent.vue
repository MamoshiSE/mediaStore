<template>
    <div id="agentPage">
        <section class="blog-section spad">



            <p class="error" v-if="error">{{ error }}</p>

            <div class="container h-100 ">
                <div class="row h-100 justify-content-center align-items-center">
                    <ul class="game-filter">
                        <li><a href="/agents/Breach">Breach</a></li>
                        <li><a href="/agents/Brimstone">Brimstone</a></li>
                        <li><a href="/agents/Cypher">Cypher</a></li>
                        <li><a href="/agents/Jett">Jett</a></li>
                        <li><a href="/agents/Omen">Omen</a></li>
                        <li><a href="/agents/Phoenix">Phoenix</a></li>
                        <li><a href="/agents/Raze">Raze</a></li>
                        <li><a href="/agents/Sage">Sage</a></li>
                        <li><a href="/agents/Sova">Sova</a></li>
                        <li><a href="/agents/Viper">Viper</a></li>

                    </ul>
                </div>

                <div class="agent-page" v-for="(agent, index) in agent" v-bind:item="agent" v-bind:index="index" v-bind:key="agent._id">
                    <div class="row h-100">
                      
                        <div class="col-xl-5 col-lg-6 col-md-6 col-xs-11 ">
                            <img :src="agent.img" class="col-12" alt="">
                            <div class="section-title text-white ">
                                <div class="agent-desc">
                                    <h2>{{agent.name}}</h2>
                                    <p class="agent-desc-text" style = 'white-space: pre-wrap;'>{{agent.desc}}</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-xl-6 col-lg-6 col-md-6 sidebar">
                            <div id="stickySidebar">
                                <!-- ABILITY ONE / #2d1854; MÖRKARE LILA FÄRG-->
                                <div class="widget-item">
                                    <div class="col-lg-12 col-md-12 col-xs-10 thumb abilities">
                                        <div class="ability" style="background: #34164b; color: white;">
                                            <div class="ability-header"><img :src="agent.abilities.one.img" alt="placeholder" class="ability-icon" style="height: 20%; width: 15%;">
                                                <div class="ability-title">
                                                    <h3 class="ability-name">{{agent.abilities.one.name}}</h3>
                                                    <div class="ability-cost">Cost: {{agent.abilities.one.cost}}</div>
                                                </div>
                                                <div class="ability-keybind ml-auto">{{agent.abilities.one.key}}</div>
                                            </div>
                                            <hr style="background: #b01ba5;">
                                            <p class="ability-description">{{agent.abilities.one.desc}}</p>
                                        </div>
                                    </div>
                                </div>
                                <!-- ABILITY ONE ENDS -->
                                <!-- ABILITY TWO -->
                                <div class="widget-item">
                                    <div class="col-lg-12 col-md-12 col-xs-10 thumb abilities">
                                        <div class="ability" style="background: #34164b; color: white;">
                                            <div class="ability-header"><img :src="agent.abilities.two.img" alt="placeholder" class="ability-icon" style="height: 20%; width: 15%;">
                                                <div class="ability-title">
                                                    <h3 class="ability-name">{{agent.abilities.two.name}}</h3>
                                                    <div class="ability-cost">Cost: {{agent.abilities.two.cost}}</div>
                                                </div>
                                                <div class="ability-keybind ml-auto">{{agent.abilities.two.key}}</div>
                                            </div>
                                            <hr style="background: #b01ba5;">
                                            <p class="ability-description">{{agent.abilities.two.desc}}</p>
                                        </div>
                                    </div>
                                </div>
                                <!-- ABILITY TWO ENDS -->
                                <!-- ABILITY THREE -->
                                <div class="widget-item">

                                    <div class="col-lg-12 col-md-12 col-xs-10 thumb abilities">
                                        <div class="ability" style="background: #34164b; color: white;">
                                            <div class="ability-header"><img :src="agent.abilities.three.img" alt="placeholder" class="ability-icon" style="height: 20%; width: 15%;">
                                                <div class="ability-title">
                                                    <h3 class="ability-name">{{agent.abilities.three.name}}</h3>
                                                    <div class="ability-cost">Cost: {{agent.abilities.three.cost}}</div>
                                                </div>
                                                <div class="ability-keybind ml-auto">{{agent.abilities.three.key}}</div>
                                            </div>
                                            <hr style="background: #b01ba5;">
                                            <p class="ability-description">{{agent.abilities.three.desc}}</p>
                                        </div>
                                    </div>
                                </div>
                                <!-- ABILITY THREE ENDS -->
                                <!-- ABILITY FOUR -->
                                <div class="widget-item">



                                    <div class="col-lg-12 col-md-12 col-xs-10 thumb abilities">
                                        <div class="ability" style="background: #34164b; color: white;">
                                            <div class="ability-header"><img :src="agent.abilities.four.img" alt="placeholder" class="ability-icon" style="height: 20%; width: 15%;">
                                                <div class="ability-title">
                                                    <h3 class="ability-name">{{agent.abilities.four.name}}</h3>
                                                    <div class="ability-cost">Cost: {{agent.abilities.four.cost}}</div>
                                                </div>
                                                <div class="ability-keybind ml-auto">{{agent.abilities.four.key}}</div>
                                            </div>
                                            <hr style="background: #b01ba5;">
                                            <p class="ability-description">{{agent.abilities.four.desc}}</p>
                                        </div>
                                    </div>
                                </div>
                                <!-- ABILITY FOUR ENDS -->
                            </div>
                        </div>
                    </div>




                </div>

            </div>

        </section>
    </div>

</template>
<style>
    // Ability


    .ability {
        display: flex;
        flex-direction: column;
        border-radius: 10px;
        border: 1px solid;
        background: #503c6e !important;
        width: 300px;
    }

    .divider {
        width: calc(100% - 30px);
    }

    .ability-header {
        display: flex;
        align-items: center;
        padding: 20px 20px 0 10px;
        color: white;
        margin-top: -10px;

    }

    .ability-icon {
        height: 50px;
        margin-right: 12px;

    }

    .ability-title {
        display: flex;
        flex-direction: column;
        margin-right: 15px;
        color: white;

    }

    .ability-name {
        font-size: 22px;
        color: white;
        text-align: left;
    }

    .ability-cost {
        display: flex;
        color: #b01ba5;
        font-size: 15px;


    }

    hr {
        margin-top: 7px;
    }

    .ability-keybind {


        display: flex;
        align-items: center;
        justify-content: center;
        width: 30px;
        height: 30px;
        min-width: 30px;
        min-height: 30px;
        border-radius: 5px;
        background: #b01ba5;
    }

    .ability-description {
        font-size: 13px;
        padding: 0 15px 15px 15px;
        overflow: auto;
        color: white;
        margin-top: -10px;
    }

    span {
        display: block;
        margin: 10px 0;
        color: red !important;
    }

    .credits {
        width: 14px;
        margin-right: 5px;
    }
    .agent-desc {
        padding: 10px 25px 10px 25px;
    }
    @media (min-width: 1200px) {
    .agent-page {
        margin-top: 20px;
    }
        #stickySidebar {
            margin-top: 10px;
        }
    }
</style>
<script>
    var axios = require("axios");

    module.exports = {
        name: 'AgentPageComponent',
        data() {
            return {
                agent: {}
            };
        },
        methods: {
            //Performs a GET request to /api/products using AXIOS.
            getAgent: function(name) {
             //   console.log("Function called");
                axios
                    .get("/api/agents/" + name)
                    .then(response => {
                        if (response.status !== 200) {
                            console.log("Wrong status code: " + response.status);
                        }
                        //
                      //  console.log("success")
                        this.agent = response.data;
                        //console.log(response.data);


                    })
                    .catch(error => {
                        //In case of error
                        console.log(error);
                    })
                    .then(function() {
                       // console.log("function ended");
                        //This code is always executed, independent of the request being successful or not.
                    });
            }
        },
        mounted() {

            this.getAgent(this.$route.params.name);
        }
    };
</script>