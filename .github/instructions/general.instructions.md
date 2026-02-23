---
description: Cada que se genere o modifique código para el proyecto
applyTo: '**/*' # when provided, instructions will automatically be added to the request context when the pattern matches an attached file
---
# Instrucciones Generales para el Proyecto

## 1. Arquitectura del proyecto
- El proyecto debe seguir una arquitectura modular y legible siguiendo los lineamientos estándares de la comunidad.
- Se deben utilizar patrones de diseño adecuados para garantizar la escalabilidad y mantenibilidad del código.
- La estructura de carpetas debe ser clara y organizada, facilitando la navegación y comprensión del proyecto.
## 2. Estilo de código
- Las consultas realizadas con el ORM deben estar pensadas en ofrecer el mayor rendimiento posible, evitando consultas innecesarias o ineficientes.
- Para los DTOs creados se deben utilizar records en lugar de clases para garantizar la inmutabilidad de los datos y mejorar la legibilidad del código.
- Cada que se requiera crear un endpoint para un recurso primero se deben definir los DTOs necesarios, después se deben crear la interfaz del servicio, posteriormente se debe implementar el servicio y finalmente se debe crear el controlador por medio de injección de dependencias.
- Cada nuevo servicio se debe registrar por medio del método de extension definido en el proyecto para garantizar la correcta inyección de dependencias y facilitar la gestión de los servicios en el proyecto.
- Los DTOs creados deben nombrar sus propiedades en inglés a pesar que el modelo con el que se trabaje tenga sus propiedades en español, esto con el fin de mantener la consistencia en el código y facilitar la comprensión para desarrolladores que puedan no estar familiarizados con el idioma español.
