<template>


    <!-- Header section -->
    <header class="header-section">
        <div class="header-warp">

            <div class="header-bar-warp d-flex">
                <!-- site logo -->
                <a href="/" class="site-logo">
                    <img src="../../public/img/logo.png" alt="">
                </a>

                <!--	<div class="user-panel">
						<a href="">Login</a> / <a href="">Register</a>
					</div> -->
                <!-- Menu -->
                <ul class="main-menu primary-menu">
                    
                    <li><a href="/">Home</a></li>
                    <li><a href="/about">Leaderboard</a></li>
                    <li><a href="/agents">Agents</a></li>
                    <li><a href="/maps">Maps</a></li>
                    <li><a href="/weapons">Weapons</a></li>
                </ul>

            </div>
        </div>
    </header>

</template>

<script>
  export default {
  name: 'NavbarComponent'
}
</script>