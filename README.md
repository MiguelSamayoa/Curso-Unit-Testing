# Base de Código para Curso de Pruebas Unitarias en .NET y C# con xUnit

Este repositorio contiene el código base desarrollado durante el curso de Platzi **"Unit Testing con C# y .NET"**. El objetivo principal del curso es proporcionar una comprensión integral de las pruebas unitarias en el entorno de desarrollo de C# y .NET.

## Características del Proyecto

- **Framework utilizado:** xUnit
- **Versión de .NET:** 9.0
- **Cobertura de pruebas:** Utiliza Coverlet para medir la cobertura de código y generar reportes.

## Contenidos Aprendidos

- Fundamentos de las pruebas unitarias.
- Escritura y ejecución de pruebas utilizando xUnit.
- Comparación entre frameworks de pruebas como NUnit y xUnit.
- Generación y análisis de reportes de cobertura con Coverlet.

## Ejecución de Pruebas

Para ejecutar las pruebas unitarias, utiliza el siguiente comando desde la terminal, posicionándote en el directorio `StringManipulation.Tests`:

```bash
dotnet test
```

### Análisis de Cobertura de Código

Para medir la cobertura de código y visualizar el resultado desde la terminal, ejecuta el siguiente comando:

```bash
dotnet test /p:CollectCoverage=true
```

### Generación de Reportes de Cobertura

Si deseas generar un reporte detallado en formato HTML, sigue los siguientes pasos:

1. Ejecuta las pruebas con generación de cobertura en formato Cobertura:

    ```bash
    dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura
    ```

2. Genera el reporte HTML utilizando `reportgenerator`:

    ```bash
    reportgenerator "-reports:coverage.cobertura.xml" "-targetdir:coverage-report" -reporttypes:html
    ```

3. El reporte generado estará disponible en el directorio `coverage-report`.

## Requisitos Previos

- Tener instalado .NET Core SDK en la versión 9.0 o superior.
- Instalar `reportgenerator` si deseas generar reportes detallados. Puedes hacerlo utilizando el siguiente comando:

    ```bash
    dotnet tool install -g dotnet-reportgenerator-globaltool
    ```

## Recursos Adicionales

- [Documentación oficial de xUnit](https://xunit.net/)
- [Coverlet en GitHub](https://github.com/coverlet-coverage/coverlet)
- [Documentación de .NET](https://learn.microsoft.com/dotnet/)
