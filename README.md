# Проект "Main Menu"

<div align="center">
  <img width="690" height="390" alt="Clown" src="https://github.com/user-attachments/assets/d8724e68-26f8-42c1-942c-494cae8775f2" />
</div>

## 🛠 Технический стек

### Архитектура и паттерны:
- **MVVM * — разделение логики
- **Hierarchical State Machine** — управление состояниями игры и навигацией по меню
- **Observer Pattern** — событийная модель через Actions/Events и Signals
- **ScriptableObject** — data‑driven конфигурация


### Core системы:
- **Audio System** — управление музыкой и звуками с AudioBank
- **Localization System** — поддержка нескольких языков
- **Save/Load System** — сохранение настроек и прогресса игрока
- **Settings Manager** — управление параметрами игры
- **Navigation History** — система навигации с поддержкой кнопки «Назад»

### UI и анимации:
- **TextMesh Pro** — продвинутый текстовый рендеринг
- **DOTween** — твин‑анимации переходов и появления окон
- **NaughtyAttributes** — расширенные возможности Inspector
- **Input System** — новая система ввода Unity
- **UI Animations Sequence** — слоистые анимации кнопок и панелей

### Визуальные эффекты:
- **Post-Processing Stack** — цветокоррекция и блум для атмосферы меню
- **Particle System** — фоновые визуальные эффекты
- **Unity Animator** — анимации фоновых объектов

### Оптимизация:
- **Addressable Assets** — асинхронная загрузка UI‑префабов и сцен
- **Sprite Atlas** — упаковка UI‑графики в атласы
- **Object Pooling** — переиспользование окон и уведомлений
- **Caching Components** — кэширование компонентов
