<a name='assembly'></a>
# Study.LabWork2.UnitTests

## Contents

- [MonitorServiceTests](#T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests')
  - [CountPrimes_FullRange_1To10000_IsCorrect()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_FullRange_1To10000_IsCorrect 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_FullRange_1To10000_IsCorrect')
  - [CountPrimes_MultipleRuns_ReturnSameResult()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_MultipleRuns_ReturnSameResult 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_MultipleRuns_ReturnSameResult')
  - [CountPrimes_NoCrashes_OnSmallRange()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_NoCrashes_OnSmallRange 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_NoCrashes_OnSmallRange')
  - [CountPrimes_SmallRange_ReturnsCorrectCount()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_SmallRange_ReturnsCorrectCount 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.CountPrimes_SmallRange_ReturnsCorrectCount')
  - [Setup()](#M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-Setup 'Study.LabWork2.UnitTests.Feature.Task1.SubTask1.MonitorServiceTests.Setup')

<a name='T-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests'></a>
## MonitorServiceTests `type`

##### Namespace

Study.LabWork2.UnitTests.Feature.Task1.SubTask1

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_FullRange_1To10000_IsCorrect'></a>
### CountPrimes_FullRange_1To10000_IsCorrect() `method`

##### Summary

Проверка на эталонном диапазоне задачи (контрольный результат = 1229)

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_MultipleRuns_ReturnSameResult'></a>
### CountPrimes_MultipleRuns_ReturnSameResult() `method`

##### Summary

Проверяем детерминированность: многопоточность не должна влиять на итог

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_NoCrashes_OnSmallRange'></a>
### CountPrimes_NoCrashes_OnSmallRange() `method`

##### Summary

Санитарный тест: проверка отсутствия падений на минимальном диапазоне

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-CountPrimes_SmallRange_ReturnsCorrectCount'></a>
### CountPrimes_SmallRange_ReturnsCorrectCount() `method`

##### Summary

Проверяем базовую корректность на маленьком диапазоне чтобы быстро поймать логические ошибки

##### Parameters

This method has no parameters.

<a name='M-Study-LabWork2-UnitTests-Feature-Task1-SubTask1-MonitorServiceTests-Setup'></a>
### Setup() `method`

##### Summary

Создаём конкретную реализацию Monitor (lock)

##### Parameters

This method has no parameters.
