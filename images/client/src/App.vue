<template>
  <div id="app">
   
      <NavbarComponent/>
    
    <router-view/>
      <FooterComponent/>
  </div>
</template>






<script>
// @ is an alias to /src
import FooterComponent from '@/components/FooterComponent.vue'
import NavbarComponent from '@/components/NavbarComponent.vue'

export default {
  name: 'Home',
  components: {
    FooterComponent,
    NavbarComponent
  }
}
</script>