<a name='assembly'></a>
# Study.LabWork2.UnitTests

## Contents

- [NumberSetProcessorTests](#T-Study-LabWork2-UnitTests-Feature-Task1-SubTask2-NumberSetProcessorTests 'Study.LabWork2.UnitTests.Feature.Task1.SubTask2.NumberSetProcessorTests')
  - [ExecutionTime_Should_BePositive()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask2-NumberSetProcessorTests-ExecutionTime_Should_BePositive 'Study.LabWork2.UnitTests.Feature.Task1.SubTask2.NumberSetProcessorTests.ExecutionTime_Should_BePositive')
  - [Process_Should_HaveUniqueSetNumbers()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask2-NumberSetProcessorTests-Process_Should_HaveUniqueSetNumbers 'Study.LabWork2.UnitTests.Feature.Task1.SubTask2.NumberSetProcessorTests.Process_Should_HaveUniqueSetNumbers')
  - [Process_Should_NotThrowExceptions_WhenRun()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask2-NumberSetProcessorTests-Process_Should_NotThrowExceptions_WhenRun 'Study.LabWork2.UnitTests.Feature.Task1.SubTask2.NumberSetProcessorTests.Process_Should_NotThrowExceptions_WhenRun')
  - [Process_Should_ProcessAllSets()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask2-NumberSetProcessorTests-Process_Should_ProcessAllSets 'Study.LabWork2.UnitTests.Feature.Task1.SubTask2.NumberSetProcessorTests.Process_Should_ProcessAllSets')
  - [Process_Should_ProduceSameResult_ForSameInputFile()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask2-NumberSetProcessorTests-Process_Should_ProduceSameResult_ForSameInputFile 'Study.LabWork2.UnitTests.Feature.Task1.SubTask2.NumberSetProcessorTests.Process_Should_ProduceSameResult_ForSameInputFile')
  - [Process_Should_Return15ResultsEntries()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask2-NumberSetProcessorTests-Process_Should_Return15ResultsEntries 'Study.LabWork2.UnitTests.Feature.Task1.SubTask2.NumberSetProcessorTests.Process_Should_Return15ResultsEntries')

<a name='T-Study-LabWork2-UnitTests-Feature-Task1-SubTask2-NumberSetProcessorTests'></a>
## NumberSetProcessorTests `type`

##### Namespace

Study.LabWork2.UnitTests.Feature.Task1.SubTask2

##### Summary

Набор тестов для проверки корректности многопоточной обработки наборов чисел.
Проверяются базовые инварианты: количество результатов, корректность сумм,
устойчивость к многопоточности и детерминизм.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask2-NumberSetProcessorTests-ExecutionTime_Should_BePositive'></a>
### ExecutionTime_Should_BePositive() `method`

##### Summary

Проверяет, что время выполнения корректно измеряется
и больше нуля (обработка действительно происходила).

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask2-NumberSetProcessorTests-Process_Should_HaveUniqueSetNumbers'></a>
### Process_Should_HaveUniqueSetNumbers() `method`

##### Summary

Проверяет, что каждый набор обработан ровно один раз.
Отсутствие уникальности означало бы гонку данных
или некорректную работу потоков.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask2-NumberSetProcessorTests-Process_Should_NotThrowExceptions_WhenRun'></a>
### Process_Should_NotThrowExceptions_WhenRun() `method`

##### Summary

Проверяет, что выполнение не приводит к исключениям.
В многопоточном коде это важно: ошибки синхронизации
часто проявляются именно как runtime-исключения.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask2-NumberSetProcessorTests-Process_Should_ProcessAllSets'></a>
### Process_Should_ProcessAllSets() `method`

##### Summary

Проверяет, что после выполнения обработки были обработаны все 15 наборов.
Это базовая гарантия того, что ни один поток не "потерялся".

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask2-NumberSetProcessorTests-Process_Should_ProduceSameResult_ForSameInputFile'></a>
### Process_Should_ProduceSameResult_ForSameInputFile() `method`

##### Summary

Проверяет детерминированность результата:
при одинаковых входных данных (файл не меняется)
итоговая сумма должна быть одинаковой.

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask2-NumberSetProcessorTests-Process_Should_Return15ResultsEntries'></a>
### Process_Should_Return15ResultsEntries() `method`

##### Summary

Проверяет, что результат содержит ровно 15 записей —
по одной на каждый набор.
Важно для проверки корректности синхронизации (lock).

##### Parameters

This method has no parameters.
