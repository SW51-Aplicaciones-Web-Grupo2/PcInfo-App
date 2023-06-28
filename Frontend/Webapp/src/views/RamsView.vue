<template>
    <header>
        <pv-toolbar style="background-color:#673ab7;">
            <template #start>
                <img src="../assets/images/logo-login.png" alt="Logo TripStore">
                <h3 style="color:black;"></h3>
            </template>

            <template #end>
                <div class="flex-column div1">
                    <router-link v-for="item2 in items2" :to="item2.to" custom v-slot="{ navigate, href }" :key="item2.label">
                        <pv-button class="p-button-text text-white" :href="href" @click="navigate">{{ item2.label }}</pv-button>
                    </router-link>
                </div>

                <div class="vertical-divider"></div>

                <div class="flex-column">
                    <router-link v-for="item in items" :to="item.to" custom v-slot="{ navigate, href }" :key="item.label">
                        <pv-button class="p-button-text text-white" :href="href" @click="navigate">{{ item.label }}</pv-button>
                    </router-link>
                </div>
            </template>


        </pv-toolbar>
    </header>
    <div>
        <div v-for="product in products" :key="product.id" class="product-container">
            <h2 class="product-card">{{ product.name }}<br>s/.{{ product.price }}<br>
                <button class="add-button" >Agregar</button>
            </h2>

            <p class="product-card">{{ product.description }}</p>
            <img :src="product.imageUrl" :alt="product.name" class="product-card"/>
        </div>
    </div>
</template>

<script>
export default {
    data() {
        return {
            products: [],
            items: [

                { label: ' Home', to: '/home'},
                { label: 'Add New Trip', to: '/addnewtrip'},
                { label: 'Profile', to: '/profile'},
                { label: 'Flights history', to: '/flighthistory'},
                { label: 'Login', to: '/login'},
            ],
            items2: [
                { label: ' Rams', to: '/rams'},
                { label: ' Solid Disks', to: '/soliddisks'},
                { label: 'Headsets', to: '/Headsets'},

            ],
        };
    },
    created() {
        fetch("./db.json")
            .then((response) => response.json())
            .then((data) => {
                this.products = data.products;
            });
    },
};
</script>

<style>
.product-container {
    display: flex;
    flex-wrap: wrap;
    justify-content: center;
    color: black;
    background-color: #fff;
    border-bottom: 2px solid black;
}
.add-button {
    position: absolute;
    bottom: 10px;
    padding: 10px;
    width: 75%;
    background-color: #673ab7;
    border: 1px solid #ccc;
    border-radius: 4px;
    box-shadow: 2px 2px 2px rgba(0, 0, 0, 0.1);
}
.product-card {
    width: 300px;
    margin: 10px;
    color: black;
}
.product-container:last-of-type {
    border-bottom: none;
}
.vertical-divider {
    border-left: 3px solid white;
    height: 100px; /* Ajusta la altura según tus necesidades */
    margin: 0 10px; /* Ajusta el margen horizontal según tus necesidades */
}



</style>
