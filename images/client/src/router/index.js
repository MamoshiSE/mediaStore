import Vue from 'vue'
import VueRouter from 'vue-router'
import Home from '../components/HomeComponent.vue'
//import Agents from '../components/AgentComponent.vue'
import AgentPageComponent from '../components/AgentPageComponent.vue'
import WeaponComponent from '../components/WeaponComponent.vue'
import WeaponPageComponent from '../components/WeaponPageComponent.vue'
import MapComponent from '../components/MapComponent.vue'
import MapPageComponent from '../components/MapPageComponent.vue'

Vue.use(VueRouter)

  const routes = [
  {
    path: '/',
    name: 'Home',
    component: Home
  },
  {
    path: '/agents',
    name: 'Agent',
      
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
   component: () => import(/* webpackChunkName: "about" */ '../components/AgentComponent.vue')
  },
       {
    path: '/agents/:name',
    name: 'AgentPageComponent',
    component: AgentPageComponent
  }, 
      {
    path: '/weapons/',
    name: 'WeaponComponent',
    component: WeaponComponent
  }, 
      {
    path: '/weapons/:name',
    name: 'WeaponPageComponent',
    component: WeaponPageComponent
  }, 
      {
    path: '/maps/',
    name: 'MapComponent',
    component: MapComponent
  }
      , 
      {
    path: '/maps/:name',
    name: 'MapPageComponent',
    component: MapPageComponent
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
