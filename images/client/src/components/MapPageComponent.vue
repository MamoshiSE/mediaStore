<template>
    <div id="MapPage">
        <section class="blog-section spad">

<h3>test</h3>

        </section>
    </div>

</template>

<script>
    var axios = require("axios");

    module.exports = {
        name: 'MapPageComponent',
        data() {
            return {
                map: {}
            };
        },
        methods: {
            //Performs a GET request to /api/products using AXIOS.
            getMap: function(name) {
                console.log("Function called");
                axios
                    .get("http://localhost:5000/api/maps/" + name)
                    .then(response => {
                        if (response.status !== 200) {
                            console.log("Wrong status code: " + response.status);
                        }
                        //
                        console.log("success")
                        this.map = response.data;
                        console.log(response.data);


                    })
                    .catch(error => {
                        //In case of error
                        console.log(error);
                    })
                    .then(function() {
                        console.log("function ended");
                        //This code is always executed, independent of the request being successful or not.
                    });
            }
        },
        mounted() {

            this.getMap(this.$route.params.name);
        }
    };
</script>