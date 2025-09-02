# Resolución Actividad 1 - TP API REST

## 1. Animales (/animales)

### **GET /animales**

Lista todos los animales.

**Parámetros query opcionales:** Se podría consultar por cualquier campo.

**Respuesta (200 OK):**

```json
[
  {
    "id": 1,
    "idTipoAnimal": 1,
    "nombre": "Firulais",
    "raza": "Labrador",
    "edad": 5,
    "sexo": "M",
    "idDueño": 2
  }
]
```

---

### **POST /animales**

Crea un nuevo animal.

**Cuerpo de petición:**

```json
{
  "tipo": "1",
  "nombre": "Michi",
  "raza": "Siamés",
  "edad": 3,
  "sexo": "F",
  "idDueño": 2
}
```
**Cuerpo de la respuesta:**

```json
{
  "id": 1
}
```

**Respuestas:**

- 201 Created
- 400 Bad Request
- 404 Not Found

---

### **GET /animales/{id}**

Obtiene un animal específico.

**Respuestas:**

- 200 OK (body con datos del animal)
- 404 Not Found

---

### **PUT /animales/{id}**

Actualiza un animal existente.

**Cuerpo de petición:** Igual que POST.

**Respuestas:**

- 200 OK (con animal actualizado)
- 400 Bad Request
- 404 Not Found

---

### **DELETE /animales/{id}**

Elimina un animal.

**Respuestas:**

- 204 No Content
- 404 Not Found

---

## 2. Dueños (/dueños)

### **GET /dueños**

Lista todos los dueños.

**Respuesta (200 OK):**

```json
[
  {
    "dni": "12345678",
    "nombre": "Juan",
    "apellido": "Perez"
  }
]
```

---

### **POST /dueños**

Crea un nuevo dueño.

**Cuerpo de petición:**

```json
{
  "dni": "12345678",
  "nombre": "Juan",
  "apellido": "Perez"
}
```
**Cuerpo de la respuesta:**

```json
{
  "id": 1
}
```
**Respuestas:**

- 201 Created
- 400 Bad Request (DNI inválido o ya existe)

---

### **GET /dueños/{id}**

Obtiene un dueño específico.

**Respuestas:**

- 200 OK
- 404 Not Found

---

### **PUT /dueños/{id}**

Actualiza un dueño.

**Cuerpo de petición:** Igual que POST.

**Respuestas:**

- 200 OK
- 400 Bad Request
- 404 Not Found

---

### **DELETE /dueños/{id}**

Elimina un dueño.

**Respuestas:**

- 204 No Content
- 400 Bad Request
- 404 Not Found

---

## 3. Atenciones (/animales/{id}/atenciones)

### **GET /animales/{id}/atenciones**

Lista todas las atenciones de un animal.

**Parámetros query opcionales:**

- `desde`: Fecha desde (YYYY-MM-DD)
- `hasta`: Fecha hasta (YYYY-MM-DD)

**Respuesta (200 OK):**

```json
[
  {
    "id": 1,
    "fechaAtencion": "2023-05-15",
    "motivo": "Control anual",
    "tratamiento": "Vacunación",
    "medicamentos": "Vacuna antirrábica",
    "fechaRegistro": "2023-05-15"
  }
]
```

---

### **POST /animales/{id}/atenciones**

Registra una nueva atención.

**Cuerpo de petición:**

```json
{
  "fechaAtencion": "2023-05-15",
  "motivo": "Control anual",
  "tratamiento": "Vacunación",
  "medicamentos": "Vacuna antirrábica"
}
```

**Validaciones:**

- `fechaAtencion` no puede ser futura.
- `fechaAtencion` no puede ser >30 días en el pasado.
- 
**Cuerpo de la respuesta:**

```json
{
  "id": 1
}
```
**Respuestas:**

- 201 Created
- 400 Bad Request (fecha inválida o datos incorrectos)
- 404 Not Found (animal no existe)

---

### **GET /animales/{id}/atenciones/{atencionId}**

Obtiene una atención específica.

**Respuestas:**

- 200 OK
- 404 Not Found

---

### **PUT /animales/{id}/atenciones/{atencionId}**

Actualiza una atención existente.

**Cuerpo de petición:** Igual que POST.

**Validaciones:** Mismas validaciones de fecha.

**Respuestas:**

- 200 OK
- 400 Bad Request
- 404 Not Found

---

### **DELETE /animales/{id}/atenciones/{atencionId}**

Elimina una atención.

**Respuestas:**

- 204 No Content
- 404 Not Found



