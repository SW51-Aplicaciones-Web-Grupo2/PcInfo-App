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
    <div class="body">
        <div class="login">
            <img src="../../assets/images/flight.jpg" alt="flight TripStore" class="retamanio">

            <div class="form-field">
                <label for="origin" class="input-label">Origin</label>
                <span  class="p-float-label p-4">
                    <pv-input-text placeholder="i.e. New York City" type="text" id="Origin" class="custom-input"/>
                </span>
            </div>


            <div class="form-field">
                <label for="destination" class="input-label">Destination</label>
                <span class="p-float-label p-4">
                    <pv-input-text placeholder="i.e. Lima" type="text" id="destination" class="custom-input"/>
                </span>
            </div>

            <div class="form-field">
                <label for="date" class="input-label">Date</label>
                <span  class="p-float-label p-4">
                    <pv-input-text placeholder="DD/MM/YYYY" type="text" id="Date" class="custom-input"/>
                </span>
            </div>


            <pv-button class="width"  label="Register"></pv-button>

        </div>
    </div>
</template>
<script>

export default {
    data() {
        return {

            drawer: false,
            items: [

                { label: ' Home', to: '/home'},
                { label: 'Add New Trip', to: '/addnewtrip'},
                { label: 'Profile', to: '/profile'},
                { label: 'Flights history', to: '/flighthistory'},
                { label: 'Login', to: '/login'},






            ]
        }
    }
}
</script>
<style scoped>
.body {
    display: flex;
    align-items: center;
    justify-content: center;
    height: 100%;
}
.login {
    width: 100%;
    padding: 15px;
    margin: auto;
    text-align: center;
}
.width {
    background-color: #673ab7;
    width: 10%;
    margin-top: 1px;

}

.changes{

    background-color: #ffd740;
    color: black;
    width: 8%;
    margin-top: 10px;

}

.logo-image {

    width: 350px;
    height: auto;

}

.retamanio{
    width: 350px;
    height: auto;
}

.form-field {
    margin-bottom: 20px;
    width: auto;
    length: 200px;
}

.input-label {
    display: block;
    color: #282828;
    margin-bottom: 1px;
    margin-top: initial;
    font-weight: bold;
    text-align: center;
}
.custom-input{
    width: 500px;
}
</style>