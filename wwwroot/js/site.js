// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
const tl = gsap.timeline({ defaults: { duration: 2 } });
tl
    .from('.Testing', { opacity: 0, y: -100 })
    .from('.texto', { scale: 0, opacity: 0 })
    .from('.agregar', { opacity: 0, x: -300 })
    .from('.lista', { x: 300, opacity: 0 }, "-=2")
    