<template>
    <div id="agentPage">
        <section class="blog-section spad">

            <ul class="sub-navbar">

                <li><a href="Classic">Sidearm</a></li>
                <li><a href="Stinger">SMG</a></li>
                <li><a href="Bucky">Shotgun</a></li>
                <li><a href="Bulldog">Rifle</a></li>
                <li><a href="Marshal">Sniper</a></li>
                <li><a href="Ares">Heavy</a></li>
            </ul>




            <div class="container h-100 ">
                <!-- <div class="row h-100 justify-content-center align-items-center"> -->

                <!-- </div> -->

                <div class="agent-page" v-for="(weapon, index) in weapon" v-bind:item="weapon" v-bind:index="index" v-bind:key="weapon._id">
                    <div class="row h-100 justify-content-center align-items-center">
                        <ul class="weapon-filter" style="position: relative; ">
                            <div v-if="weapon.type == 'Sidearm'">
                                <li class="col-md-12" v-for="(weapons,idx) in sidearm" v-bind:key="idx"><a v-bind:href="weapons.name">{{weapons.name}}</a>

                                    <a v-bind:href="weapons.name"><img :src="weapons.img" alt="" class="weapon-filter-image" style="width: 40%;">
                                        <p class="weapon-filter-cost ">
                                            <img src="/img/credits.svg" width="10" height=10> {{weapons.cost}}</p>
                                    </a>

                                </li>

                            </div>
                            <div v-else-if="weapon.type == 'SMG'">
                                <li v-for="(weapons,idx) in smg" v-bind:key="idx"><a v-bind:href="weapons.name">{{weapons.name}}</a>
                                    <a v-bind:href="weapons.name"><img :src="weapons.img" alt="" class="weapon-filter-image">
                                        <p class="weapon-filter-cost ">
                                            <img src="/img/credits.svg" width="10" height=10> {{weapons.cost}}</p>
                                    </a>
                                </li>
                            </div>
                            <div v-else-if="weapon.type == 'Shotgun'">
                                <li v-for="(weapons,idx) in shotgun" v-bind:key="idx"><a v-bind:href="weapons.name">{{weapons.name}}</a>
                                    <a v-bind:href="weapons.name"><img :src="weapons.img" alt="" class="weapon-filter-image">
                                        <p class="weapon-filter-cost ">
                                            <img src="/img/credits.svg" width="10" height=10> {{weapons.cost}}</p>
                                    </a>
                                </li>
                            </div>
                            <div v-else-if="weapon.type == 'Rifle'">
                                <li v-for="(weapons,idx) in rifle" v-bind:key="idx"><a v-bind:href="weapons.name">{{weapons.name}}</a>
                                    <a v-bind:href="weapons.name"><img :src="weapons.img" alt="" class="weapon-filter-image">
                                        <p class="weapon-filter-cost ">
                                            <img src="/img/credits.svg" width="10" height=10> {{weapons.cost}}</p>
                                    </a>
                                </li>
                            </div>
                            <div v-else-if="weapon.type == 'Sniper'">
                                <li v-for="(weapons,idx) in sniper" v-bind:key="idx"><a v-bind:href="weapons.name">{{weapons.name}}</a>
                                    <a v-bind:href="weapons.name"><img :src="weapons.img" alt="" class="weapon-filter-image">
                                        <p class="weapon-filter-cost ">
                                            <img src="/img/credits.svg" width="10" height=10> {{weapons.cost}}</p>
                                    </a>
                                </li>
                            </div>
                            <div v-else-if="weapon.type == 'Heavy'">
                                <li v-for="(weapons,idx) in heavy" v-bind:key="idx"><a v-bind:href="weapons.name">{{weapons.name}}</a>
                                    <a v-bind:href="weapons.name"><img :src="weapons.img" alt="" class="weapon-filter-image">
                                        <p class="weapon-filter-cost ">
                                            <img src="/img/credits.svg" width="10" height=10> {{weapons.cost}}</p>
                                    </a>
                                </li>
                            </div>

                        </ul>
                    </div>
                    <div class="row h-100 justify-content-center">


                        <div class="weapon-page-image col-xl-4 col-lg-4 col-md-4 col-sm-11 col-xs-10">

                            <img :src="weapon.img" class="img-fluid" alt="" style="display: block; margin: auto;">
                            <div class="section-title text-white ">
                                <div class="weapon-desc" style="position: absolute; bottom: -8px; left: 15px;">
                                    <h2>{{weapon.name}}</h2>
                                    <p style='white-space: pre-wrap'>{{weapon.type}}</p>
                                </div>
                                <p style='white-space: pre-wrap; float: right; bottom: 0; right: 15px; position: absolute;'><img src="/img/credits.svg" width="20" height=20> {{weapon.cost}}</p>
                            </div>
                        </div>
                        <div class="col-xl-6 col-lg-8 col-md-8 col-sm-12 col-xs-12 sidebar">
                            <div id="stickySidebar">
                                <div class="widget-item">

                                    <div class="ability" style="background: #34164b; color: white;">
                                        <div class="ability-header" style="background: #b01ba5; border-top-right-radius: 15px;">
                                            <div class="ability-title">
                                                <h3 class="ability-name" style="margin-top: -10px; margin-bottom: 10px;">Weapon Stats</h3>

                                            </div>

                                        </div>
                                        <br>






                                        <div class="weapon-table-row">
                                            <h4 class="ability-name" style="color: #b01ba5;">Damage</h4>
                                        </div>
                                        <div class="weapon-table-row">
                                            <div v-if="weapon.LowRange">

                                                <div class="ability-title">
                                                    <p class="ability-name weapon-range">{{weapon.LowRange}}</p>
                                                    <svg data-v-6435d374="" viewBox="0 0 33.316 80" class="col-lg-12" style="margin-left: -10px; margin-top: -15px;" width=125 height=125>
                                                        <g data-v-6435d374="" transform="translate(-636.875 -624)">
                                                            <circle data-v-6435d374="" cx="6.153" cy="6.153" r="6.153" transform="translate(647.387 624)" fill="#ff4655"></circle>
                                                            <path data-v-6435d374="" d="M666.16 664.832l-5.115-12.794-1.352 6.831h-12.306l-1.363-6.84-5.117 12.8a2.05 2.05 0 11-3.96-1.058l6.369-23.772h.008a2.055 2.055 0 012.012-1.639h4.1l4.109 4.1 4.1-4.1h4.111a2.048 2.048 0 012.016 1.712l6.352 23.7a2.05 2.05 0 11-3.959 1.061z" fill="#ff99a2" opacity=".996"></path>
                                                            <path data-v-6435d374="" d="M647.753 704h-6.52l5.862-41.025h12.893l5.857 41.021h-6.508l-5.798-32.821-5.786 32.824z" fill="#ffe6e8"></path>
                                                        </g>
                                                    </svg>
                                                    <div style="margin-top: -125px; margin-left: 90px;">
                                                        <p style="color:#ff4655;">{{weapon.LowRangeHead}}</p>
                                                        <p style="color:#ff99a2; margin-top: -5px;"> {{weapon.LowRangeBody}}</p>
                                                        <p style="color:#ffe6e8;"> {{weapon.LowRangeLeg}}</p>
                                                    </div>

                                                </div>
                                            </div>
                                            <div v-if="weapon.MidRange">

                                                <div class="ability-title">

                                                    <p class="ability-name weapon-range">{{weapon.MidRange}}</p>

                                                    <svg data-v-6435d374="" viewBox="0 0 33.316 80" class="col-lg-12" style="margin-left: -10px; margin-top: -15px;" width=125 height=125>
                                                        <g data-v-6435d374="" transform="translate(-636.875 -624)">
                                                            <circle data-v-6435d374="" cx="6.153" cy="6.153" r="6.153" transform="translate(647.387 624)" fill="#ff4655"></circle>
                                                            <path data-v-6435d374="" d="M666.16 664.832l-5.115-12.794-1.352 6.831h-12.306l-1.363-6.84-5.117 12.8a2.05 2.05 0 11-3.96-1.058l6.369-23.772h.008a2.055 2.055 0 012.012-1.639h4.1l4.109 4.1 4.1-4.1h4.111a2.048 2.048 0 012.016 1.712l6.352 23.7a2.05 2.05 0 11-3.959 1.061z" fill="#ff99a2" opacity=".996"></path>
                                                            <path data-v-6435d374="" d="M647.753 704h-6.52l5.862-41.025h12.893l5.857 41.021h-6.508l-5.798-32.821-5.786 32.824z" fill="#ffe6e8"></path>
                                                        </g>
                                                    </svg>
                                                    <div style="margin-top: -125px; margin-left: 90px;">
                                                        <p style="color:#ff4655;">{{weapon.MidRangeHead}}</p>
                                                        <p style="color:#ff99a2; margin-top: -5px;"> {{weapon.MidRangeBody}}</p>
                                                        <p style="color:#ffe6e8;"> {{weapon.MidRangeLeg}}</p>
                                                    </div>


                                                </div>

                                            </div>
                                            <div v-if="weapon.LongRange">

                                                <div class="ability-title">
                                                    <p class="ability-name weapon-range">{{weapon.LongRange}}</p>
                                                    <svg v-if="weapon.LongRange" data-v-6435d374="" viewBox="0 0 33.316 80" class="col-lg-12" style="margin-left: -10px; margin-top: -15px;" width=125 height=125>
                                                        <g data-v-6435d374="" transform="translate(-636.875 -624)">
                                                            <circle data-v-6435d374="" cx="6.153" cy="6.153" r="6.153" transform="translate(647.387 624)" fill="#ff4655"></circle>
                                                            <path data-v-6435d374="" d="M666.16 664.832l-5.115-12.794-1.352 6.831h-12.306l-1.363-6.84-5.117 12.8a2.05 2.05 0 11-3.96-1.058l6.369-23.772h.008a2.055 2.055 0 012.012-1.639h4.1l4.109 4.1 4.1-4.1h4.111a2.048 2.048 0 012.016 1.712l6.352 23.7a2.05 2.05 0 11-3.959 1.061z" fill="#ff99a2" opacity=".996"></path>
                                                            <path data-v-6435d374="" d="M647.753 704h-6.52l5.862-41.025h12.893l5.857 41.021h-6.508l-5.798-32.821-5.786 32.824z" fill="#ffe6e8"></path>
                                                        </g>
                                                    </svg>

                                                    <div style="margin-top: -125px; margin-left: 90px;">
                                                        <p style="color:#ff4655;">{{weapon.LongRangeHead}}</p>
                                                        <p style="color:#ff99a2; margin-top: -5px;"> {{weapon.LongRangeBody}}</p>
                                                        <p style="color:#ffe6e8;"> {{weapon.LongRangeLeg}}</p>
                                                    </div>

                                                </div>
                                            </div>


                                        </div>
                                        <hr style="background: #b01ba5; margin-top: 30px;">
                                        <div class="weapon-table-row">

                                            <p class="ability-name">Magazine Size</p>
                                            <p class="ability-name">{{weapon.magSize}}</p>
                                        </div>

                                        <div class="weapon-table-row">

                                            <p class="ability-name">Wall Penetration</p>
                                            <p class="ability-name">{{weapon.penetration}}</p>
                                        </div>
                                        <hr style="background: #b01ba5;">
                                        <div class="weapon-table-row">
                                            <h3 class="ability-name" style="color: #b01ba5;">Primary fire</h3>
                                        </div>
                                        <div class="weapon-table-row">

                                            <p class="ability-name">Mode</p>
                                            <p class="ability-name">{{weapon.mode}}</p>
                                        </div>
                                        <div class="weapon-table-row">
                                            <p class="ability-name" style="margin-top: -15px;">Fire rate</p>
                                            <p class="ability-name" style="margin-top: -15px;">{{weapon.fireRate}}</p>
                                        </div>
                                        <div class="weapon-table-row">


                                            <h3 class="ability-name" style="color: #b01ba5;">{{weapon.SecondaryFire}}</h3>

                                        </div>
                                        <div v-if="weapon.SecondaryFireMode">
                                            <div class="weapon-table-row">
                                                <p class="ability-name">Mode</p>
                                                <p class="ability-name">{{weapon.SecondaryFireMode}}</p>
                                            </div>
                                            <div class="weapon-table-row">
                                                <p class="ability-name" style="margin-top: -15px;">Fire rate</p>
                                                <p class="ability-name" style="margin-top: -15px;">{{weapon.SecondaryFireRate}}</p>
                                            </div>
                                        </div>

                                    </div>

                                </div>

                            </div>
                        </div>
                    </div>




                </div>

            </div>

        </section>
    </div>

</template>
<style>
    .weapon-filter {
        list-style: none;
        display: block;
        margin-bottom: 30px;

    }

    .weapon-filter li {
        background: rgb(52, 22, 75);
        display: inline-block;
        vertical-align: top;
        text-align: center;
        height: 120px;
        width: 180px;
        border-radius: 20px;

    }

    .weapon-filter li a {
        display: block;
        color: #fff;
        padding: 16px;
        font-size: 16px;
        font-weight: 700;

        line-height: 1.1;
        height: 120px;

        margin-top: -10px;
        -webkit-transition: all 0.3s;
        -o-transition: all 0.3s;
        transition: all 0.3s;
        margin-bottom: 0px;

    }

    .weapon-filter li img {
        display: inline-block;
        margin: 0 auto;



    }

    .weapon-table-row {
        display: flex;
        flex-wrap: wrap;
    }

    .weapon-table-row .ability-name {
        flex: 1 1 auto;
        margin-left: 40px;

    }
    
    .weapon-table-row .ability-title {
        flex: 1 1 auto;
        margin-left: 20px;
    }


    .weapon-filter-cost {

        position: absolute;
        bottom: 0;
    }

    .weapon-filter li .weapon-filter-image {
        opacity: 0.4;
        width: 60%;
        margin-top: -120px;
    }
    .weapon-page-image {
        background: #34164b; 
        padding: 40px 40px 40px 40px; 
        height: 200px;
    }


    @media (max-width: 767px) {
        .sidebar {
            padding-right: 0px;
            padding-left: 0px;
        }

        .weapon-table-row .ability-name {
            flex: 1;

            margin: 5px;
            /* and that, will result in a 10px gap */
           

        }
        
        .weapon-table-row .weapon-range {
            text-align: center;
            margin-bottom: 15px;

        }
        
        .weapon-table-row .ability-title {
        flex: 0 50%;
            
            margin-bottom: 20px;
            
    }
        .weapon-page-image {
        padding-top: 10px;
        height: 150px;
    }
        #agentPage {
            margin-top: -30px;
        }
        
          .weapon-filter {
      
        margin-bottom: 20px;

    }

    .weapon-filter li {
        height: 80px;
        width: 150px;
        border-radius: 0px;

    }
        
         .weapon-filter li .weapon-filter-image {
        margin-top: -160px;
             width: 40%;
    }
.weapon-filter-cost {

        position: absolute;
        bottom: -10px;
    }

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
        name: 'WeaponPageComponent',
        data() {
            return {
                weapon: {},
                weapons: []
            };
        },
        methods: {
            //Performs a GET request to /api/products using AXIOS.
            getWeapon: function(name) {
                // console.log("Function called");
                axios
                    .get("/api/weapons/" + name)
                    .then(response => {
                        if (response.status !== 200) {
                            //           console.log("Wrong status code: " + response.status);
                        }
                        //
                        //     console.log("success")
                        this.weapon = response.data;
                        // console.log(response.data);


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
        computed: {
            sidearm() {
                return this.weapons.filter(i => i.type == 'Sidearm')
            },
            smg() {
                return this.weapons.filter(i => i.type == 'SMG')
            },
            shotgun() {
                return this.weapons.filter(i => i.type == 'Shotgun')
            },
            rifle() {
                return this.weapons.filter(i => i.type == 'Rifle')
            },
            sniper() {
                return this.weapons.filter(i => i.type == 'Sniper')
            },
            heavy() {
                return this.weapons.filter(i => i.type == 'Heavy')
            },
        },
        mounted() {

            this.getWeapon(this.$route.params.name);
            axios.get("/api/weapons/")
                .then(response => {
                    if (response.status !== 200) {
                        console.log("Wrong status code: " + response.status);
                    }
                    //
                    // console.log("success")
                    this.weapons = response.data;
                    //console.log(response.data);



                })
                .catch(error => {
                    //In case of error
                    console.log(error);
                })
                .then(function() {
                    //  console.log("function ended");
                    //This code is always executed, independent of the request being successful or not.
                });





        }
    };
</script>