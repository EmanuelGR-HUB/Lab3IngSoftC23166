<template>
    <div class="container mt-5"> 
    <h1 class="display-4 text-center">Lista de países</h1> 
    <table 
        class="table is-bordered is-striped is-narrow is-hoverable is-fullwidth"> 
        <thead> 
            <tr> 
                <th>Nombre</th> 
                <th>Continente</th> 
                <th>Idioma</th> 
                <th>Acciones</th> 
            </tr> 
        </thead> 
        <tbody> 
            <tr v-for="(pais, index) in paises" :key="index"> 
                <td>{{ pais.nombre}}</td> 
                <td>{{ pais.continente}}</td> 
                <td>{{ pais.Idioma}}</td> 
                <td> 
                    <button class="btn btn-secondary btn-sm">Editar</button> 
                    <button class="btn btn-danger btn-sm" v-on:click="eliminarPais(pais)">Eliminar</button> 
                </td> 
            </tr> 
        </tbody> 
    </table> 
</div> 

    
</template>

<script>
export default {
    name: 'ListaPaises',
    data() { 
        return { 
            paises: [ 
                { nombre: "Costa Rica", continente: "América", Idioma: "Español" }, 
                { nombre: "Japón", continente: "Asia", Idioma: "Japonés" }, 
                { nombre: "Corea del Sur", continente: "Asia", Idioma: "Coreano" }, 
                { nombre: "Italia", continente: "Europa", Idioma: "Italiano" }, 
                { nombre: "Alemania", continente: "Europa", Idioma: "Alemán" }, 
            ], 
        }; 
    },
    methods: { 
        // Método para eliminar un país de la lista
        eliminarPais(pais) {
            this.paises = this.paises.filter(p => p.nombre !== pais.nombre);
        }
    },
};
    
</script>
<style lang="scss" scoped>
</style>