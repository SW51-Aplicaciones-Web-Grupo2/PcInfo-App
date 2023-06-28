<template>
    <header >
        <pv-toolbar   style="background-color:#673ab7;">
            <template #start>
                <img src="../../assets/images/logo-login.png" alt="Logo TripStore">
                <h3 style="color:black;"></h3>
            </template>
            <template #end>

                <pv-button
                        class="p-button-text text-white"
                        :href="href"
                        @click="navigate">
                </pv-button>
                <div class="flex-column">
                    <router-link v-for="item in items"
                                 :to="item.to"
                                 custom
                                 v-slot="{ navigate, href }"
                                 :key="item.label">
                        <pv-button
                                class="p-button-text text-white"
                                :href="href"
                                @click="navigate">{{ item.label }}
                        </pv-button>
                    </router-link>
                </div>
            </template>
        </pv-toolbar>
    </header>
    <div>
        <button @click="showPopup">Mostrar Pop-up</button>
        <div v-if="show">
            <div class="popup-overlay" @click="hidePopup"></div>
            <div class="popup">
                <p>Este es el contenido del Pop-up</p>
                <button @click="hidePopup">Cerrar</button>
            </div>
        </div>
    </div>
</template>

<script>

export default {



    name: "DialogComponent",
    data() {
        return {
            show: false,

            items: [

                { label: ' Home', to: '/home'},
                { label: 'Add New Trip', to: '/addnewtrip'},
                { label: 'Profile', to: '/profile'},
                { label: 'Flights history', to: '/flighthistory'},
                { label: 'Login', to: '/login'},






            ],


        }
    },
    methods: {
        showPopup() {
            this.show = true;
        },
        hidePopup() {
            this.show = false;
        }
    }
};
</script>

<style>
.popup-overlay {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background: rgba(0, 0, 0, 0.5);
    z-index: 999;
}
.popup {
    position: fixed;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    background: #fff;
    padding: 20px;
    border-radius: 5px;
    z-index: 1000;
}
</style>