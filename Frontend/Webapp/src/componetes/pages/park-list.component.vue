
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
    <div class="card">
        <div class="col m12 card-panel">
            <div class="col m4">
                <h1>Parking's List</h1>
            </div>
        </div>
    </div>
    <div class="wrapper" v-for="parkSpace in parkingSpaces">
        <pv-card class="m-2">
            <template #header>
                <img :alt="parkSpace.title" :src="parkSpace.image">
            </template>
            <template #title>
                <p>{{ parkSpace.name }}</p>
            </template>
            <template #content>
                <p>{{ parkSpace.location }}</p>
            </template>
        </pv-card>


    </div>

    <div class="button">
        <pv-button label="Look for other options" class="p-button-raised p-button-rounded  mr-2" @click="openNew"/>
        <pv-button label="Parking Graph" class="p-button-raised p-button-rounded mr-2" @click="openNew"/>
    </div>



</template>

<script>
import {FlightsApiService} from "../services/flights-api.service";
export default {
    name: "park-list.component",
    data() {
        return {
            parkingSpaces: [],

            items: [

                { label: ' Home', to: '/home'},
                { label: 'Add New Trip', to: '/addnewtrip'},
                { label: 'Profile', to: '/profile'},
                { label: 'Flights history', to: '/flighthistory'},
                { label: 'Login', to: '/login'},






            ],

            parkingSpacesService: null
        };
    },
    created() {
        this.parkingSpacesService = new FlightsApiService();
        this.parkingSpacesService.getAll().then((response) => {
            this.parkingSpaces = response.data;
            console.log(this.parkingSpaces);
        });
    },
    methods: {
    }
}

</script>

<style scoped>
.wrapper{
    max-height: 400px;
    min-height: 400px;
    min-width: 400px;
    max-width: 400px;
    border: 1px solid #dddddd;
    display: flex;
    overflow-x: auto;
    float:left;
}
.wrapper::-webkit-scrollbar{
    width: 0px;
}
.wrapper .item{
    min-width: 400px;
    height: 350px;
    line-height: 200px;
    text-align: center;
    color: black;
    background-color: #dddddd;
    margin-right: 5px;
    margin-left: 5px;
}


.button{
    margin: 15px;
    position: fixed;
    top: 800px;
}
</style>