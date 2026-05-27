<a name='assembly'></a>
# Study.LabWork2

## Contents

- [AsynchronousServerRequestApp](#T-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp')
  - [ExecuteRequestsAsync\`\`1()](#M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-ExecuteRequestsAsync``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]- 'Study.LabWork2.Feature.Task2.AsynchronousServerRequestApp.ExecuteRequestsAsync``1(Study.LabWork2.Abstractions.Feature.Task2.DtoModels.ServerConfigDto[])')
- [MonitorService](#T-Study-LabWork2-Feature-Task1-SubTask1-MonitorService 'Study.LabWork2.Feature.Task1.SubTask1.MonitorService')
- [MutexService](#T-Study-LabWork2-Feature-Task1-SubTask1-MutexService 'Study.LabWork2.Feature.Task1.SubTask1.MutexService')
- [NumberSetProcessor](#T-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor 'Study.LabWork2.Feature.Task1.SubTask2.NumberSetProcessor')
  - [_lockObj](#F-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor-_lockObj 'Study.LabWork2.Feature.Task1.SubTask2.NumberSetProcessor._lockObj')
  - [_results](#F-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor-_results 'Study.LabWork2.Feature.Task1.SubTask2.NumberSetProcessor._results')
  - [_sets](#F-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor-_sets 'Study.LabWork2.Feature.Task1.SubTask2.NumberSetProcessor._sets')
  - [_totalSum](#F-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor-_totalSum 'Study.LabWork2.Feature.Task1.SubTask2.NumberSetProcessor._totalSum')
  - [GetResult()](#M-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor-GetResult 'Study.LabWork2.Feature.Task1.SubTask2.NumberSetProcessor.GetResult')
  - [LoadOrGenerateSets()](#M-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor-LoadOrGenerateSets 'Study.LabWork2.Feature.Task1.SubTask2.NumberSetProcessor.LoadOrGenerateSets')
  - [ProcessSet(index)](#M-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor-ProcessSet-System-Int32- 'Study.LabWork2.Feature.Task1.SubTask2.NumberSetProcessor.ProcessSet(System.Int32)')
- [SemaphoreService](#T-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService 'Study.LabWork2.Feature.Task1.SubTask1.SemaphoreService')
- [SynchronousServerRequestApp](#T-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp 'Study.LabWork2.Feature.Task2.SynchronousServerRequestApp')

<a name='T-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp'></a>
## AsynchronousServerRequestApp `type`

##### Namespace

Study.LabWork2.Feature.Task2

##### Summary

Асинхронная версия приложения (с использованием async/await)

<a name='M-Study-LabWork2-Feature-Task2-AsynchronousServerRequestApp-ExecuteRequestsAsync``1-Study-LabWork2-Abstractions-Feature-Task2-DtoModels-ServerConfigDto[]-'></a>
### ExecuteRequestsAsync\`\`1() `method`

##### Summary

Асинхронное выполнение запросов

##### Parameters

This method has no parameters.

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-MonitorService'></a>
## MonitorService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Версия 1. Использует Monitor (lock) для синхронизации

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-MutexService'></a>
## MutexService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Версия 2. Использует Mutex для синхронизации

<a name='T-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor'></a>
## NumberSetProcessor `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask2

##### Summary

Реализация процессора наборов чисел.
Выполняет многопоточную обработку с использованием:
Semaphore (ограничение потоков),
Monitor/lock (синхронизация списка),
Mutex (синхронизация общей суммы).

<a name='F-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor-_lockObj'></a>
### _lockObj `constants`

##### Summary

Объект для блокировки (Monitor/lock)
Используется для защиты списка результатов

<a name='F-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor-_results'></a>
### _results `constants`

##### Summary

Общий список результатов по каждому набору

<a name='F-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor-_sets'></a>
### _sets `constants`

##### Summary

Наборы чисел, загруженные из файла или сгенерированные

<a name='F-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor-_totalSum'></a>
### _totalSum `constants`

##### Summary

Общий список результатов по каждому набору

<a name='M-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor-GetResult'></a>
### GetResult() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor-LoadOrGenerateSets'></a>
### LoadOrGenerateSets() `method`

##### Summary

Загружаем или генерируем наборы чисел

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-Feature-Task1-SubTask2-NumberSetProcessor-ProcessSet-System-Int32-'></a>
### ProcessSet(index) `method`

##### Summary

Обрабатывает один набор чисел:
- считает сумму
- записывает результат
- обновляет общий итог

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-Study-LabWork2-Feature-Task1-SubTask1-SemaphoreService'></a>
## SemaphoreService `type`

##### Namespace

Study.LabWork2.Feature.Task1.SubTask1

##### Summary

Версия 3. Использует Semaphore для синхронизации

<a name='T-Study-LabWork2-Feature-Task2-SynchronousServerRequestApp'></a>
## SynchronousServerRequestApp `type`

##### Namespace

Study.LabWork2.Feature.Task2

##### Summary

Синхронная версия приложения (без использования async/await)
