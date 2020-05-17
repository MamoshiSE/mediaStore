<template>
<div class="map">
  <section class="blog-section spad">
        <div class="container">
           
                    <div class="section-title text-white">
                        <h2 class="text-center">Valorant Maps</h2>
                    </div>



        
    
    <p class="error" v-if="error">{{ error }}</p>
      <div class="row top-buffer">
    <div class= "col-lg-4 col-md-4 col-xs-6 thumb" v-for="map in maps" v-bind:key="map">

               
                    <a v-bind:href="'maps/'+ map.name" >
                        <img :src="map.img" class="zoom img-fluid " alt="">
                  
                     <h3 class="agent-name text-center" >{{map.name}}</h3>
                          </a>


        </div>
    </div>
    </div>
    </section>
    </div>

   
</template>
<style>
     @media (min-width: 768px) {
    .map {
        margin-bottom: 370px !important;
    }
    }
    
     @media (min-width: 1024px) {
    .map {
        margin-bottom: 139px !important;
    }
    }

</style>
<script>
    var axios = require("axios");
 

    module.exports = {
        name: 'MapComponent',
        data() {
            return {
                maps: [],
            };
        },
         
        methods: {
            goToMapPage(name) {
    window.location.href ="maps/" + name;
                  
  }
        },
      
    
        mounted() {

            axios.get("api/maps/")
                    .then(response => {
                        if (response.status !== 200) {
                            console.log("Wrong status code: " + response.status);
                        }
                        //
                       // console.log("success")
                        this.maps = response.data;
                        //console.log(response.data);


                    })
                    .catch(error => {
                        //In case of error
                        console.log(error);
                    })
                    .then(function() {
                    //    console.log("function ended");
                        //This code is always executed, independent of the request being successful or not.
                    });
        }
    };
</script>

