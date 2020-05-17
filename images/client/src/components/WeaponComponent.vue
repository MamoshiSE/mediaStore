<template>
  <section class="blog-section spad">
        <div class="container container-weapons">
           
                      <div class="table-responsive" style="text-align: center;">
  <table class="table table-dark table-striped">
    <thead>
      <tr>
       <th id="hiddenHeader">Image</th>
        <th>Name</th>
        <th>Type</th>
        <th>Cost</th>
        <th>Mode</th>
        <th>Mag Size</th>
       <!-- <th>Fire Rate</th> -->
      <!--  <th>Range</th> -->
      <!--  <th>Head</th>-->
       <!-- <th>Body</th>-->
       <!-- <th>Leg</th>-->
        <th>Wall Penetration</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for="(weapon, i) in weapons" :key="i" class="weaponRow" @click="goToWeaponPage(weapon.name)"> 
        <td><img :src="weapon.img" class="img-fluid weapon-image" alt=""></td>
        <td>{{weapon.name}}</td>
        <td>{{weapon.type}}</td>
        <td>{{weapon.cost}}</td>
        <td>{{weapon.mode}}</td>
        <td>{{weapon.magSize}}</td>
       <!-- <td>{{weapon.fireRate}}</td> -->
       <!--  <td>{{weapon.range}}</td>-->
       <!--  <td>{{weapon.head}}</td>-->
       <!--  <td>{{weapon.body}}</td>-->
      <!--   <td>{{weapon.leg}}</td>-->
        <td>{{weapon.penetration}}</td>
    
      </tr>
    </tbody>
  </table>
    </div>



        
    
    <p class="error" v-if="error">{{ error }}</p>
   
    </div>
   
    </section>

   
</template>
<style>
    #hiddenHeader {
        color: #2d1854;
    }
    
    a {
        color: white;
        background-color: none;
    }
    
    .weaponRow:hover{
   cursor:pointer; 
    }

</style>
<script>
    var axios = require("axios");

    module.exports = {
        name: 'WeaponComponent',
        data() {
            return {
                weapons: [],
            };
        },
        methods: {
            goToWeaponPage(name) {
    window.location.href ="weapons/" + name;
                  
  }
        },
    
        mounted() {

            axios.get("api/weapons/")
                    .then(response => {
                        if (response.status !== 200) {
                            console.log("Wrong status code: " + response.status);
                        }
                        //
                      //  console.log("success")
                        this.weapons = response.data;
                        //console.log(response.data);


                    })
                    .catch(error => {
                        //In case of error
                        console.log(error);
                    })
                    .then(function() {
                     //   console.log("function ended");
                        //This code is always executed, independent of the request being successful or not.
                    });
        }
    };
</script>

