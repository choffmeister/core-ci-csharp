###
  Copyright (C) 2013 Christian Hoffmeister

  This program is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 3 of the License, or
  (at your option) any later version.

  This program is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with this program. If not, see {http://www.gnu.org/licenses/}.
###
define [
  "angular"
  "./controllers/DashboardController"
  "./controllers/ConnectController"
  "./controllers/LoginController"
  "./controllers/LogoutController"
  "./controllers/MainController"
  "./controllers/ProfileController"
  "./controllers/ProjectAddController"
  "./controllers/ProjectController"
  "./controllers/RegisterController"
  "./controllers/TaskController"
],
(angular, controllers...) ->
  # register module
  module = angular.module("coreci.controllers", [])

  # register all controllers
  for controller in controllers
    controllerName = controller.$name
    module.controller(controllerName, controller)